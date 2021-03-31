using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SOLID.DIP
{
    public class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee emp1, Employee emp2)
        {
            if (emp1 is null && emp2 is null)
            {
                return true;
            }

            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            return emp1.Id == emp2.Id && emp1.Name == emp2.Name && emp1.Department == emp2.Department && emp1.Salary == emp2.Salary;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Id, obj.Name, obj.Department, obj.Salary);
        }
    }
}
