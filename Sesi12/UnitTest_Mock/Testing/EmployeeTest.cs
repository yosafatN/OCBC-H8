using System;
using Xunit;
using Moq;
using UnitTest_Mock.Services;

namespace Testing
{
    public class EmployeeTest
    {
        #region Property
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeeById ()
        {
            mock.Setup(p => p.GetEmployeeById(1)).ResturnsAsync("JK");
            EmployeeController
        }
    }
}
