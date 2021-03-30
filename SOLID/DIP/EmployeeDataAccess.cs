namespace SOLID.DIP
{
    class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new()
            {
                ID = id,
                Name = "Your",
                Department = "IT",
                Salary = 10000
            };

            return emp;
        }
    }
}
