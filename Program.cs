﻿using System;
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
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=10; i++) // 0-9 1-10
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i*number);
            }


            Console.ReadLine();
        }
    }
}
