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
            int age = 10;
            age /= 3;
            int remaindar = age % 3;
            Console.WriteLine(age);
            Console.WriteLine(remaindar);

            string name = "Omar";
            name += " loves programming";

            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++); // 0
            Console.WriteLine(++i); // 2 

          

            Console.ReadLine();
        }
    }
}
