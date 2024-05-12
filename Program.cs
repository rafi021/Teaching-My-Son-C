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
            string textAge = "5";
            int age = Convert.ToInt32(textAge);

            Console.WriteLine("My text Age: " + textAge);
            Console.WriteLine("My int Age: " + age);
            Console.WriteLine(textAge.GetType());
            Console.WriteLine(age.GetType());

            string textBigNumber = "-900000000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(textBigNumber);
            Console.WriteLine(bigNumber.GetType());



            Console.ReadLine();
        }
    }
}
