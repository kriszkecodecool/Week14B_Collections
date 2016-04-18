﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            int inputInt;
            string inputString;
            Console.WriteLine("Please enter some numbers. When finished write a blank line.");
            while ((inputString = Console.ReadLine()) != "")
            {
                inputInt = int.Parse(inputString);
                stack.Push(inputInt);
            }
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}
