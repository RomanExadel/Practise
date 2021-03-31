namespace SOLID.DIP
{
    class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            var emp = new Employee()
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
