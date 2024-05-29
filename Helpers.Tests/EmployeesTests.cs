using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    public class EmployeesTests
    {

        [Fact]
        public void Constructor_SholdThrow_ArgumentNullException_WhenNameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee(null, 35000));
        }
    }
}
