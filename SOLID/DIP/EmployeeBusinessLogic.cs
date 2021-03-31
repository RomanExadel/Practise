using Unity;

namespace SOLID.DIP
{
    public class EmployeeBusinessLogic
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;

        [InjectionConstructor]
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
