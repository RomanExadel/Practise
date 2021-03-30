using Practise.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Practise.EqualityComparers
{
    class CarEqualityComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car car1, Car car2)
        {
            if (car1 is null && car2 is null)
            {
                return true;
            }

            if (car1 is null || car2 is null)
            {
                return false;
            }

            return car1.Name == car2.Name && car1.Mileage == car2.Mileage;
        }

        public int GetHashCode([DisallowNull] Car obj)
        {
            return HashCode.Combine(obj.Name, obj.Mileage);
        }
    }
}
