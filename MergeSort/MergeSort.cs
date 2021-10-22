using System;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort\n");
            string[] fruits = { "A", "S", "W", "B" ,"K"};

            Console.WriteLine("Before sort :\n");

            foreach (var i in fruits)
            {
                Console.WriteLine(i);
            }

            MergeSort m = new MergeSort();
            m.mergesort(fruits);


        }
        public  void mergesort(string[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            if (arr == null)
            {
                return;
            }

            if (arr.Length>1)
            {
              int mid = arr.Length / 2;

             string[] left = new string[mid];

             for( i = 0; i <mid; i++)
             {
                left[i] = arr[i];
             }

             string[] right = new string[arr.Length - mid];

              for( i = mid; i < arr.Length; i++)
              {
                   right[i-mid] = arr[i];
              }
                
                while (i < left.Length && j < right.Length)
                {
                if(left[i].CompareTo( right[j])>0){
                    arr[k] = left[i];
                    i++;
                } 
                else 
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
                }
                while (i < left.Length)
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }
                while (j < right.Length)
                {
                    arr[k] = right[j];
                    j++;
                    k++;
                }
            }


            Console.WriteLine("\n After sort :\n");

            for( i=0;i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
       




    }
}

