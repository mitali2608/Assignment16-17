using System;

namespace PalindromeNumber
{
    class Palindrome
    {
        static void Main(string[] args)
        {
           
            int num2 = 0, num1 = 0;
            int i = 0;
            Console.WriteLine("Program to get Prime Palindrome number");
            Console.WriteLine("----------------------------------");

            for (i = 0; i <= 1000; i++)
            {
                num1 = i;
                num2 = 0;
                while (num1 != 0)
                {
                    int rem = num1 % 10;
                    num1 /= 10;
                    num2 = num2 * 10 + rem;
                }

                   if (i == num2 && i%2!=0)
                    Console.WriteLine(i + " ");
            }



        }

    }
}
  

   
 

