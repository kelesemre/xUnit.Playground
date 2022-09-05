﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.ConsoleApp
{
    public class Customer
    {
        public string Name => "Emre";
        public int Age => 35;

        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("ErrorX");
            }
            return 100;
        }
        public virtual int GetOrdersByName2(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("OnlyException");
            }
            return 100;
        }
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }

    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }

        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
            {
                return new Customer();
            }
            return new LoyalCustomer();
        }
    }
}
