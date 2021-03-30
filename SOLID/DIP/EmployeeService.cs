namespace SOLID.DIP
{
    class EmployeeService
    {
        EmployeeBusinessLogic _employeeBL;

        public EmployeeService()
        {
            _employeeBL = new EmployeeBusinessLogic(new EmployeeDataAccess());
        }

        public Employee GetCustomerName(int id)
        {
            return _employeeBL.GetEmployeeDetails(id);
        }
    }
}
