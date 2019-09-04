using System;
using System.Collections.Generic;
using System.Text;

namespace ScientificCalculator
{
    class CalculatorBase
    {
        public virtual void DoIt()
        {
            Console.WriteLine("CalculatorBase.Doit()");
        }

        public virtual string GetDescription()
        {
            return "[blank]";
        }

        public string GetNextNumberSuffix(int n)
        {
            //we only need up to 100
            if (n >= 100)
                n %= 100;

            //11 to 13 are 'special cases'
            if (n >= 11 && n <= 13)
                return "th";

            //'switch' for the last digit
            switch (n % 10)//i % 10 gives us the Units
            {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
        }

        public virtual double GetNextNumber(int n)
        {
            Console.Write($"Enter {n}{GetNextNumberSuffix(n)} number: ");
            return double.Parse(Console.ReadLine());
        }

        public virtual double GetNextNumber()
        {
            Console.Write("Enter number: ");
            return double.Parse(Console.ReadLine());
        }
    }
}
