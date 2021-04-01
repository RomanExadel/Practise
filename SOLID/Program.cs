using SOLID.DIP;
using System;
using Unity;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IEmployeeDataAccess, EmployeeDataAccess>();

            EmployeeBusinessLogic employee = container.Resolve<EmployeeBusinessLogic>();
            Console.WriteLine(employee.GetEmployeeDetails(1));
        }
    }
}
