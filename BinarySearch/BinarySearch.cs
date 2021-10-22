using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace BinarySearch
{
    class BinarySearch
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search :\n");


            //Reading file
            string[]lines = File.ReadAllLines(@"E:\dotnet\DataStructure\Algorithms\BinarySearch\TextFile.txt");
            Console.WriteLine("Before sort :");

            //printing content of file
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("-----------------------------------------");

            //counting no of lines 
            int size = lines.Length;
            Console.WriteLine("\t No of lines in file : " + size);
            Console.WriteLine("-----------------------------------------");

            // bubble sort for sorting array
            for (int index = 0; index < (size - 1); index++)
            {
                //if first string is greater than second then swap
                if (string.Compare(lines[index], lines[index + 1]) > 0) 
                {
                    //swap

                    string temp = lines[index];
                    lines[index] = lines[index + 1];
                    lines[index + 1] = temp;

                }
            }
            //printing content of file after sort performed

            Console.WriteLine("After sort :");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("Enter word you want to key :");
            string word = Console.ReadLine();
            // calling search function
            BinarySearch.Bsearch(lines, word);
        }
        //search function
        public static int Bsearch(string[] lines, string key)
        {
            int first = 0;
            int last = lines.Length - 1;
            
            int mid = (first + last) / 2;
            while (first <= last)
            {
                if (lines[mid].CompareTo(key) < 0)
                    first = mid + 1;
                else if (lines[mid] == key)
                {
                    Console.WriteLine("Word found!!  " + key);
                    break;
                }
                else
                    last = mid - 1;

                mid = (first + last) / 2;
            }
            if (first > last)
            {
                Console.WriteLine("Word not found!!  " + key);

            }
            return 0;
        }

    }
}



    




        
       

        