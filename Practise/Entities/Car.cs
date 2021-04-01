using System;

namespace Practise.Entities
{
    abstract class Car : IEquatable<Car>
    {
        private string _name;
        private double _mileage;

        public Car(string name, double mileage)
        {
            Name = name;
            Mileage = mileage;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name can't be null", nameof(value));
                }

                _name = value;
            }
        }

        public double Mileage
        {
            get => _mileage;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentOutOfRangeException("Mileage can't be less than zero", nameof(value));
                }

                _mileage = value;
            }
        }

        public static explicit operator string(Car car)
        {
            return car.Name;
        }

        public abstract void StartEngine();

        public virtual void BlowUpCar()
        {
            Console.WriteLine("Boom");
        }

        public static void ChangeMileage(Car car, double mileage)
        {
            car.Mileage = mileage;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Mileage);
        }

        public bool Equals(Car car)
        {
            if (car is null)
            {
                return false;
            }

            return Name == car.Name && Mileage == car.Mileage;
        }
    }
}
