using System;
using System.Collections.Generic;
using System.Text;

namespace ScientificCalculator
{
    class CalculatorOfLife
    {
        public int Exit = 0;
        public int Selection = 0;
        public bool DoLoop = true;

        public List<CalculatorBase> list;

        public CalculatorOfLife()
        {
            Initialise();
        }

        private void Initialise()
        {
            list = new List<CalculatorBase>();

            list.Add(new Addition());

            //Exit, this should always be added last
            list.Add(new EndCalculator());

            Exit = list.Count;
        }

        public void StartCalculator()
        {
            do
            {
                Console.Clear();

                PrintMenu(list);

                Selection = GetSelection();

                Console.WriteLine();

                DoLoop = ProcessSelection(list, Selection);

                if (DoLoop)
                {
                    Console.WriteLine("\nEnter any key to continue...");
                    Console.ReadLine();
                }

            } while (DoLoop);
        }

        void PrintMenu(List<CalculatorBase> list)
        {
            Console.WriteLine("CALCULATOR!!!\n");

            //print all function descriptions
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"{i + 1}. {list[i].GetDescription()}");

            Console.WriteLine();
            Console.Write("Please make a selection: ");
        }

        int GetSelection()
        {
            return int.Parse(Console.ReadLine());
        }

        bool ProcessSelection(List<CalculatorBase> list, int selection)
        {
            //if 'selection' is is higher than number of functions, then its not valid
            if (selection <= 0 || selection > list.Count)
            {
                Console.WriteLine("Invalid choice..\n\n");
                return true;
            }

            //call selection's DoIt()
            list[selection - 1].DoIt();

            if (selection == Exit)
                return false;//signal that Exit has been selected
            else
                return true;//signal to continue
        }
    }
}
