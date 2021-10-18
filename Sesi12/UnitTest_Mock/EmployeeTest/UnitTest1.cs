using System;
using Xunit;
using Moq;
using UnitTest_Mock.Services;
using UnitTest_Mock.Models;
using UnitTest_Mock.Controllers;


namespace Testing
{
    public class EmployeeTest
    {
        #region Property
        public Mock<IEmployeeService> mock = new();
        #endregion

        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p => p.GetEmployeeById(1)).ReturnsAsync("JK");
            EmployeeController emp = new(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }

        [Fact]
        public async void GetEmpoyeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "Jk",
                Desgination = "SDE"
            };

            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }
    }
}
