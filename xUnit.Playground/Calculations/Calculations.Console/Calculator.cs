﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.ConsoleApp
{
    public class Calculator
    {
        public List<int> FiboNumbers { get => new List<int>() { 1, 1, 2, 3, 5, 8, 13 };}
        public int Name { get; private set; }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double AddDouble(double a, double b)
        {
            return a + b;
        }

        public bool IsOdd(int value)
        {
            return (value % 2) == 1;
        }
    }
}
