using System;

namespace InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort\n");
            string[] fruits = { "Green Apple", "Sweet Lemon", "Watermelon", "Blueberyy" };

            Console.WriteLine("Before sort :\n");

            foreach (var i in fruits)
            {
                Console.WriteLine(i);
            }
            InsertionSort obj = new InsertionSort();
            obj.Insertion(fruits);
        }


        internal void Insertion(string[] fruits)
        {

            int size = fruits.Length;

            for(int i = 1; i < size; i++)
            {
                string key = fruits[i];
                int j = i - 1;

               while ((j >= 0) && (fruits[j].CompareTo(key) > 0))
                {
                    fruits[j + 1] = fruits[j];
                    j--;
                }

                fruits[j + 1] = key;
            }
            Console.WriteLine("\nAfter sort :\n");

            foreach (var i in fruits)
            {
                Console.WriteLine(i);
            }


        }
    }

}
