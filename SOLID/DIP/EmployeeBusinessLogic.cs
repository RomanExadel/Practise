namespace SOLID.DIP
{
    class EmployeeBusinessLogic
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
