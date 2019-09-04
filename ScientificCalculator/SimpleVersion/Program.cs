using System;
using System.Collections.Generic;

namespace SimpleVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CalculatorBase> list = new List<CalculatorBase>();

            list.Add(new Addition());
            list.Add(new Addition());
            list.Add(new Addition());

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"{i + 1}. {list[i].GetDescription()}");

            Console.WriteLine("\n");

            list[0].DoIt();//Althought this is a CalculatorBase, it is calling Addition.DoIt()!! thanks to 'override'
        }

    }


    class CalculatorBase
    {
        public virtual void DoIt()
        {
        }
        public virtual string GetDescription()
        {
            return "[blank]";
        }
    }

    class Addition : CalculatorBase
    {
        public override void DoIt()
        {
            Console.WriteLine("Total is: " + "xxx");
        }

        public override string GetDescription()
        {
            return "Addition";
        }
    }
}
