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

            Console.Write("Enter a number to get quotient & reminder: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number by which Number is to be divide: ");
            int dividingNumber = Convert.ToInt32(Console.ReadLine());

            int quotient = number / dividingNumber;
            int reminder = number % dividingNumber;

            Console.WriteLine($"The quotient is {quotient} & the reminder is {reminder}");
        }
    }
}
