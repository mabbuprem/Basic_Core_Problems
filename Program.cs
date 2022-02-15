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
            Console.Write("Enter 1st number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int x;
            x = number1;
            number1 = number2;
            number2 = x;
            Console.WriteLine($"Numbers after swapping:-\nnumber1:{number1} & number2: {number2}");

        }
    }
}
