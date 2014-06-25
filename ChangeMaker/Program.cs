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
            double Quarters = 0.25;
            double Dimes = 0.10;
            double Nickels = 0.05;
            double Pennies = 0.01;

            if(number)
            {
                
            }


        }

    }
}
