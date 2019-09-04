using System;
using System.Collections.Generic;
using System.Text;

namespace ScientificCalculator
{
    class EndCalculator : CalculatorBase
    {
        public override void DoIt()
        {
            Console.WriteLine("\nGoodbye :(");
        }

        public override string GetDescription()
        {
            return "Exit";
        }
    }
}
