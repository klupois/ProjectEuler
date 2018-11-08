using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, Sum = 0;
            for (i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                {
                    Console.Write("{0}\t", i);
                    Sum = Sum + i;
                }
            }
            Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}", Sum);
            Console.Read();
        }
    }
}
