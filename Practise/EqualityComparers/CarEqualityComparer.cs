using Practise.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.EqualityComparers 
{
    class CarEqualityComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car car1, Car car2)
        {
            return car1.Name == car2.Name && car1.Mileage == car2.Mileage;
        }

        public int GetHashCode([DisallowNull] Car obj)
        {
            return HashCode.Combine(obj.Name, obj.Mileage);
        }
    }
}
