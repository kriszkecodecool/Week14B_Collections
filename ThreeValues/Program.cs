using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bela", "jozsi", "geza" };
            LinkedList<string> names = new LinkedList<string>(words);
            names.AddFirst("aladar");
            names.AddLast("teszt");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
