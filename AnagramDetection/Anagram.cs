using System;

namespace AnagramDetection
{
    class Anagram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anagram Detection \n");

            Console.WriteLine("Enter first string:");
            string first = Console.ReadLine();// heart,
            char[] s1 = first.ToLower().ToCharArray(); // heart = char s1[]={'h' ,'e', 'a', 'r', 't'} 


            Console.WriteLine("Enter second string:");
            string second = Console.ReadLine();
            char[] s2 = second.ToLower().ToCharArray(); // earth = chart s2[]= {'e', 'a' 'r', 't', 'h'}



            Array.Sort(s1); //heart = aehrt
            Array.Sort(s2); //earth = aehrt
            Console.WriteLine("\nSorted string:");

            string sort1 = new string(s1); // converting char[]s1 => string sort1
            Console.WriteLine(sort1);
            string sort2 = new string(s2);
            Console.WriteLine(sort2);

            if (sort1 == sort2)
            {
                Console.WriteLine(first + " and " + second + "  are Anagrams");
            }
            else
            {
                Console.WriteLine(first + " and " + second + "  are not Anagrams");

            }
        }
    }
}
