﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();  

            Assert.NotNull(customer.Name);
            Assert.False(String.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckLegiForDiscount() 
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrderByNameNotNull()
        {
            var customer = new Customer();

            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("Hello", exceptionDetails.Message);
        }
    }
}
