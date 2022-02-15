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
            Console.WriteLine("Welcome to basic Core Programs");
            numbers N1 = new numbers(200, 546, 955);
            N1.LargestNumber();
        }
        public class numbers
        {
            int number1;
            int number2;
            int number3;

            public numbers(int number1, int number2, int number3)
            {
                this.number1 = number1;
                this.number2 = number2;
                this.number3 = number3;
            }
            public void LargestNumber()
            {
                if (number1 > number2 && number1 > number3)
                {
                    Console.WriteLine($"{number1} is largest");
                }
                else if (number2 > number1 && number2 > number3)
                {
                    Console.WriteLine($"{number2} is largest");
                }
                else
                {
                    Console.WriteLine($"{number3} is largest");
                }
            }
        }
    }
}
