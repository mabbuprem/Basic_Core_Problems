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
            Console.Write("Enter the number: ");
            //VARIABLES
            int number = Convert.ToInt32(Console.ReadLine());
            string result = number % 2 == 0 ? "Number is even" : "Number is odd";
            Console.WriteLine(result);
        }
    }
}
