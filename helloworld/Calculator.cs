using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Calculator
    {
        public void AdditiontwoNumbers()
        { 
            int FirstNo =0 , SecondNo =0 ;

            Console.WriteLine("Enter the 1st No : ");
            FirstNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd No : ");
            SecondNo= Convert.ToInt32(Console.ReadLine());
            int result = FirstNo + SecondNo;
            Console.WriteLine("Addition : " +result);
        }
    }
}
