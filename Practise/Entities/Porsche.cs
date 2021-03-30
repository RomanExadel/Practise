using Practise.Interfaces;
using System;

namespace Practise.Entities
{
    class Porsche : Car, IEquatable<Porsche>, ICheap, IExpensive
    {
        private string _model;

        public Porsche(string name, string model, double mileage = 0) : base(name, mileage)
        {
            Model = model;
        }

        public string Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _model = value;
            }
        }

        public new void BlowUpCar()
        {
            Console.WriteLine("Minus Porsche");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Launched");
        }

        void IExpensive.Sound()
        {
            Console.WriteLine("Expensive sound");
        }

        void ICheap.Sound()
        {
            Console.WriteLine("Cheap sound");
        }

        public static bool operator >(Porsche porsche1, Porsche porsche2) => porsche1.Mileage > porsche2.Mileage;

        public static bool operator <(Porsche porsche1, Porsche porsche2) => porsche1.Mileage < porsche2.Mileage;

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Model);
        }

        public bool Equals(Porsche porsche)
        {
            if (porsche is null)
            {
                return false;
            }

            return Name == porsche.Name && Model == porsche.Model;
        }
    }
}
