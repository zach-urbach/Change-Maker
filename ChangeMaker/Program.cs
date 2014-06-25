using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is ChangeMaker
            ChangeMaker(3.18);
            Console.WriteLine();
            ChangeMaker(0.99);
            Console.WriteLine();
            ChangeMaker(12.93);
            Console.WriteLine();
            ChangeMaker(4.17);

            //keeps window oppen
            Console.ReadKey();
        }
        static void ChangeMaker(double number)
        {
            //the function
            double change = number;
            int QuartersTot = 0;
            int DimesTot = 0;
            int NickelsTot = 0;
            int PenniesTot = 0;
            
            //filter out quarters
            while (change >= 0.25 )
            {
                QuartersTot += 1;
                change = change - .25;
            }

            //filter out dimes
            while (change >= 0.10)
            {
                DimesTot += 1;
                change = change - .10;
            }

            //filter out nickels
            while (change >= 0.05)
            {
                NickelsTot += 1;
                change = change - .05;
            }

            //filter out pennies
            while (change >= 0.01)
            {
                PenniesTot += 1;
                change = change - .01;
            }

            //printout the function
            Console.WriteLine(number);
            Console.WriteLine("quarters: " + QuartersTot);
            Console.WriteLine("dimes: " + DimesTot);
            Console.WriteLine("nickels: " + NickelsTot);
            Console.WriteLine("pennies: " + PenniesTot);
        }

    }
}
