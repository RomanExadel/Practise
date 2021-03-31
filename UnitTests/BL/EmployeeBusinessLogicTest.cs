using Moq;
using SOLID.DIP;
using UnitTests.DbContext;
using Xunit;

namespace UnitTests.BL
{
    public class EmployeeBusinessLogicTest
    {
        Mock<IEmployeeDataAccess> _mockEmployeeDAL;

        public EmployeeBusinessLogicTest()
        {
            _mockEmployeeDAL = new Mock<IEmployeeDataAccess>();
            _mockEmployeeDAL.Setup(dal => dal.GetEmployeeDetails(1)).Returns(EmployeeMockData.GetEmployeeDetails(1));
        }

        [Fact]
        public void GetEmployeeDetails_GetEmployeeById_ReturnsEmployee()
        {
            //Arrange
            var expectedOutputEmployee = new Employee()
            {
                Id = 1,
                Name = "Your",
                Department = "IT",
                Salary = 10000
            };

            var employeeBL = new EmployeeBusinessLogic(_mockEmployeeDAL.Object);

            //Act
            var employee = employeeBL.GetEmployeeDetails(1);

            //Assert
            Assert.Equal(expectedOutputEmployee, employee, new EmployeeEqualityComparer());
        }
    }
}
