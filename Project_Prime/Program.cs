using System;

namespace Project_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long largestFact = 0;

            for (long i = 2; i <= 17; i++)
            {
                if (17 % i == 0)
                { // It is a divisor
                    bool isPrime = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        largestFact = i;
                        Console.Write(i);
                        Console.Read();
                    }
                }
            }
        }
    }
}
