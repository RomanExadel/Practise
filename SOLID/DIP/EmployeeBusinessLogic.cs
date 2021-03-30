namespace SOLID.DIP
{
    class EmployeeBusinessLogic
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
