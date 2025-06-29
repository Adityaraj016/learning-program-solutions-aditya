using System;

namespace CalcLibrary
{
    public class Calculator
    {
        private double result;

        public double Add(double a, double b)
        {
            return result = a + b;
        }

        public double Subtract(double a, double b)
        {
            return result = a - b;
        }

        public double Multiply(double a, double b)
        {
            return result = a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");
            return result = a / b;
        }

        public double GetResult => result;

        public void AllClear()
        {
            result = 0;
        }
    }
}
