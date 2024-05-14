using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /*
         Ask user to input message
        print in order
        print in reverse
         */
        static void Main(string[] args)
        {
            int[] numbers = new int[3];  // define numbers array which have 3 items
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }

            int[] angles = {5,10,15};

            //Console.WriteLine(angles);

            Console.ReadLine();
        }
    }
}
