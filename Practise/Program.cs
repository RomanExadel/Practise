using Practise.Entities;
using Practise.Interfaces;
using Practise.Structures;
using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
