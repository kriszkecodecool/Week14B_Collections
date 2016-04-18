using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericToText
{
    class Program
    {
        static void Main(string[] args)
        {
            string toConvert;
            string converted = "";
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(0, "zero");
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            dict.Add(5, "five");
            dict.Add(6, "six");
            dict.Add(7, "seven");
            dict.Add(8, "eight");
            dict.Add(9, "nine");
            Console.WriteLine("Please enter some numbers that we should convert to a string.");
            toConvert = Console.ReadLine();
            foreach (char c in toConvert)
            {
                int digit = int.Parse(c.ToString());
                if (dict.ContainsKey(digit))
                {
                    converted += dict[digit] + " ";
                }
            }
            Console.WriteLine(converted);
            Console.ReadLine();

        }
    }
}
