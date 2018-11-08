using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c=0;
            int i = 0;
            int sum = 0;

            //Console.Write("{0}\t", a);
            //Console.Write("{0}\t", b);
            
          while(c< 50)
            {
                if (c % 2 == 0)
                {
                    Console.Write("{0}\t", c);
                    sum = sum + c;
                }

                c = a + b;
                a = b;
                b = c;
                //Console.Write("{0}\t", c);
            }
            Console.Write("{0}\t", sum);

            Console.Read();

        }
    }
}
