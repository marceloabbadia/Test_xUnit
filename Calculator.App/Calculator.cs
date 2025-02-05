using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(params int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
                sum += num;

            return sum;
        }

        public double Divide(int v1, int v2)
        {
            if (v2 == 0)
                throw new DivideByZeroException();

            return v1 / (double)v2;
        }

        public double Multiply(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}