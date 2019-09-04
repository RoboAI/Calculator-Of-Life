using System;
using System.Collections.Generic;

namespace ScientificCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            var calculator = new CalculatorOfLife();

            calculator.StartCalculator();

            Console.ReadLine();
        }
    }
}
