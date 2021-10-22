using System;

namespace PrimeRange
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 0-1000 \n");
              
            bool isPrime = true;

            int i, j;
            Console.WriteLine("Prime Numbers are : ");
            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
                
            }



        }
     
    
    
    }
 }

