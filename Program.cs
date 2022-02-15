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
            LeapYear Y1 = new LeapYear(1500);
            Y1.CheckLeapYear();
        }
    }
    public class LeapYear
    {
        public int year;

        public LeapYear(int year)
        {
            this.year = year;
        }
        public void CheckLeapYear()
        {
            if (year > 1000)
            {

                if (year % 400 == 0 && year % 100 == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else if (year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Please enter a four digit Number");
            }
        }

    }

}
