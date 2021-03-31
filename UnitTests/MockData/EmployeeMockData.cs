using SOLID.DIP;

namespace UnitTests.DbContext
{
    public static class EmployeeMockData
    {
        public static Employee GetEmployeeDetails(int id)
        {
            Employee emp = new()
            {
                Id = id,
                Name = "Your",
                Department = "IT",
                Salary = 10000
            };

            return emp;
        }
    }
}
