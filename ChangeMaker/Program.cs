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
            ChangeMaker(0.99);
            ChangeMaker(12.93);
            Console.WriteLine();
            ChangeMaker(4.17);

            Console.ReadKey();
        }
        static void ChangeMaker(double number)
        {
            int QuartersTot = 0;
            int DimesTot = 0;
            int NickelsTot = 0;
            int PenniesTot = 0;
            double Quarters = 0.25;
            double Dimes = 0.10;
            double Nickels = 0.05;
            double Pennies = 0.01;

            while (number >= 0.25 )
            {
                QuartersTot += 1;
                number = number - 0.25;
            }
            while (number >= 0.10)
            {
                DimesTot += 1;
                number = number - 0.10;
            }
            while (number >= 0.05)
            {
                NickelsTot += 1;
                number = number - 0.05;
            }
            while (number >= 0.01)
            {
                PenniesTot += 1;
                number = number - 0.01;
            }


        }

    }
}
