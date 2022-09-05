using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.ConsoleApp.Tests
{
    [Collection("Customer")]
    public class CustomerDetailTests
    {
        private readonly CustomerFixture _fixture;

        public CustomerDetailTests(CustomerFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void GetFullName_FivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _fixture.CustomerInstance;
            Assert.Equal("Emre Keles", customer.GetFullName("Emre", "Keles"));
        }
    }
}
