using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class SwapTwoNumber
    {
        public int first,second,temp;

        public void SwapNumbers()
        {
            Console.WriteLine("Please enter first number");
            first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swaping two number");
            Console.WriteLine("first number: " +first+ "Second number: " +second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After swapped");
            Console.WriteLine("first number: " + first + "Second number: " + second);



        }
    }
}
