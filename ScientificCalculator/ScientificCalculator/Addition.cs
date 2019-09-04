using System;
using System.Collections.Generic;
using System.Text;

namespace ScientificCalculator
{
    class Addition : CalculatorBase
    {
        public override void DoIt()
        {
            Console.WriteLine("Total is: " + (int)(GetNextNumber(1) + GetNextNumber(2)));
        }

        public override string GetDescription()
        {
            return "Addition";
        }
    }
}
