using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;

         
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
        private int PerformOperation(int first, int second, string operation)
        {
            switch (operation)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    if (second == 0)
                    {
                        throw new ArgumentException("Cannot divide by zero.");
                    }
                    return first / second;
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }
    }
}

