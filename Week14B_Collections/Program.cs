using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14B_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            String inputString;
            Console.WriteLine("Please enter some words. When finished write a blank line.");
            while ((inputString = Console.ReadLine()) != "")
            {
                list.Add(inputString);
            }
            list.Sort();
            foreach (String line in list)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
