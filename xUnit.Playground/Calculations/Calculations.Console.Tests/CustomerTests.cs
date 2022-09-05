using Xunit;
using System;
using Calculations.ConsoleApp.Tests;

namespace Calculations.ConsoleApp
{
    [Collection("Customer")]
    public class CustomerTests
    {
        private readonly CustomerFixture _fixture;

        public CustomerTests(CustomerFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = _fixture.CustomerInstance;
            Assert.False(string.IsNullOrEmpty(customer.Name));
            Assert.NotNull(customer.Name);
        }

        [Fact]
        public void CheckAgeRange()
        {
            var customer = _fixture.CustomerInstance;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = _fixture.CustomerInstance;
            var errDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.Equal("ErrorX", errDetails.Message);
        }

        [Fact]
        public void LocalCustomerForOrderGreaterThan100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(105);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer); // return The object, casted to type T when successful
            Assert.Equal(10, loyalCustomer.Discount);
        }
        [Fact]
        public void GetOrdersByNameNotNull2()
        {
            var customer = _fixture.CustomerInstance;
            Assert.Throws<Exception>(() => customer.GetOrdersByName2(null));
        }
    }
}
