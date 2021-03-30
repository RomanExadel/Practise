using Practise.Entities;
using Practise.EqualityComparers;
using Practise.Interfaces;
using Practise.Structures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ClassPractise
            Car car1 = new Porsche("TurboS", "911");
            Car car2 = new Porsche("TurboS", "911", 1000);

            car1.BlowUpCar();

            if (car1 is Porsche porsche1 && car2 is Porsche porsche2)
            {
                porsche1.BlowUpCar();

                ((IExpensive)porsche1).Sound();
                ((ICheap)porsche1).Sound();

                Console.WriteLine($"Mileage: {porsche1.Mileage}");
                Car.ChangeMileage(porsche1, 777);
                Console.WriteLine($"Mileage: {porsche1.Mileage}");

                Console.WriteLine($"operator >: {porsche1 > porsche2}");

                Console.WriteLine($"Equals: {porsche1.Equals(porsche2)}");

                CarMileageEqualityComparer carMileageEquality = new();
                Console.WriteLine($"CarMileageEqualityComparer: {carMileageEquality.Equals(porsche1, porsche2)}");

                string carName = (string)porsche1;
                Console.WriteLine($"ExplicitCast: {carName}");
            }
            #endregion
            #region StructurePractise
            Console.WriteLine("--------------");
            Process process1 = new("word.exe");
            Process process2 = new("word.exe");
            ProcessNameEqualityComparer processNameEquality = new();

            Console.WriteLine($"Equals: {process1.Equals(process2)}");
            Console.WriteLine($"ProcessNameEqualityComparer: {processNameEquality.Equals(process1, process2)}");

            Console.WriteLine($"RunningTime before operator ++: {process1.RunningTime}");
            process1++;
            Console.WriteLine($"RunningTime: {process1.RunningTime}");

            Process.ChangeRunningTime(process1);
            Console.WriteLine($"Using ChangeRunningTime: {process1.RunningTime}");

            Process.ChangeRunningTimeByRef(ref process1);
            Console.WriteLine($"Using ChangeRunningTimeByRef: {process1.RunningTime}");

            Process.ChangeRunningTimeByOut(out process1);
            Console.WriteLine($"Using ChangeRunningTimeByOut: {process1.RunningTime}");
            #endregion
            #region EqualityCompare
            Console.WriteLine("--------------");
            List<Car> cars = new()
            {
                new Porsche("TurboS", "911", 1000),
                new Porsche("TurboS", "911", 1000),
                new Porsche("TurboS", "911", 500),
                new Porsche("Turbo", "911", 500),
            };

            Console.WriteLine($"cars[0] is equal cars[1]? {cars[0].Equals(cars[1])}");
            Console.WriteLine($"cars[0] is equal cars[2]? {cars[0].Equals(cars[2])}");

            Console.WriteLine("Distinct with CarEqualityComparer");
            foreach (var car in cars.Distinct(new CarEqualityComparer()))
            {
                Console.WriteLine($"{car.Name} {car.Mileage}");
            }

            Console.WriteLine("Distinct with CarMileageEqualityComparer");
            foreach (var car in cars.Distinct(new CarMileageEqualityComparer()))
            {
                Console.WriteLine($"{car.Name} {car.Mileage}");
            }
            #endregion
        }
    }
}
