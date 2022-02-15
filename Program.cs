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
            Console.Write("Enter the alphabet: ");
            //VARIABLES
            char word = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (word)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("This is a vowel alphabet");
                    break;
                default:
                    Console.WriteLine("This is a consonant");
                    break;
            }
        }
    }
}
