using System;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort\n");

            int[] arr = { 55, 77, 22, 99, 88, 44, 230 };
            
            Console.WriteLine("Before sort :\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} \t",arr[i]);
            }

            BubbleSort b = new BubbleSort();
            b.Bubble(arr);
        }


        internal void Bubble(int[] arr)
        {
            int i = 0, j = 0;

            for(i=0;i<arr.Length;i++)
            {
                for (j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n After sort :\n");

            for ( i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} \t", arr[i]);
            }

        }

    }
}
