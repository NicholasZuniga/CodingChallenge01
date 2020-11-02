using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    x = x + i;
                }
            }
            Console.WriteLine("The Sum of of all the multiples of 3 and 5 below 100 is "+ x);

        }
    }
}
