using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Omar bin Ibrahim!");

            string name = "Omar bin Ibrahim";
            char letter = 'o';

            Console.Write("Your name is: ");
            Console.Write(name);
            Console.WriteLine();
            Console.WriteLine(letter);

            Console.WriteLine(name[3]);


            Console.ReadLine();
        }
    }
}
