using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");
            Console.ReadLine();
            Calculator c = new Calculator();
            c.AdditiontwoNumbers();
            Console.ReadLine();
        }

    }
}
