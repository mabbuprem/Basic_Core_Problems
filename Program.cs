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
            Console.Write("Enter the vallue of N: ");
            //VARIABLES
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= N)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
                i++;
            }
        }

    }

}
