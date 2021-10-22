using System;
using System.Collections.Generic;

namespace GenericLinarySearch
{
    public class GenericSearch<T> where T : IComparable
    {
        public T[] value;
        public T searched_key;
        public GenericSearch(T[] value, T searched_key)
        {
            this.value = value;
            this.searched_key = searched_key;
        }

        public bool search(T[] values, T key)
        {
            for (int i = 0; i < values.Length; i++)
            {


                if (values[i].Equals(key))
                {
                    return true;
                }

            }
                return false;
            
        }

       

        public void PrintSearchValue()
        {
            
            if (search(value,searched_key))
            {
                Console.WriteLine("Found value : "+searched_key);
            }
            else
            {
                Console.WriteLine(" Not Found "+searched_key);

            }

        }
    }
}
