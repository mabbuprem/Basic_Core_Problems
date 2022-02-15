using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class CorePrograms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic Core Programms");
            //CONSTANTS
            const int MAXNUMBEROFFLIPPINGCOIN = 20;
            //VARIABLES
            int noOfFlipping = 0;
            int tailCounter = 0;
            int headCounter = 0;

            while (noOfFlipping < MAXNUMBEROFFLIPPINGCOIN)
            {
                Random random = new Random();
                double flipCoin = random.NextDouble();
                int result = flipCoin < 0.5 ? tailCounter++ : headCounter++;
                noOfFlipping++;
            }
            Console.WriteLine($"The percentage of HEAD winning is {headCounter * 100 / MAXNUMBEROFFLIPPINGCOIN}");
            Console.WriteLine($"The percentage of TAIL winning is {tailCounter * 100 / MAXNUMBEROFFLIPPINGCOIN}");
        }
    }
}
