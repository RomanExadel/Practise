using Practise.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Practise
{
    class CarMileageEqualityComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car x, Car y)
        {
            return x.Mileage == y.Mileage;
        }

        public int GetHashCode([DisallowNull] Car obj)
        {
            return obj.Mileage.GetHashCode();
        }
    }
}
