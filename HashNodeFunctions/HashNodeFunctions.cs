using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Node
    {
        public int data;
        public Node next;

        public Node() { }

        public Node(int data)
        {
            this.data = data;
        }
    }

    class HashNodeFunctions
    {

        Node[] chain = new Node[11];

        public void init()
        {
            int i;
            for (i = 0; i < 11; i++)
                chain[i] = null;
        }

        public void insert(int value)
        {
            Node newNode = new Node(value);
            newNode.data = value;
            newNode.next = null;

            //calculate hash key
            int key = value % 11;

            //check if chain[key] is empty
            if (chain[key] == null)
                chain[key] = newNode;
            //collision then add next to present key
            else
            {
                //add the node at the end of chain[key].
                Node temp = chain[key];
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = newNode;
            }
        }

        public void print()
        {
            int i;

            for (i = 0; i < 11; i++)
            {
                Node temp = chain[i];
                Console.Write("chain[{0}] ---", i);
                while (temp != null)
                {
                    Console.Write("\t" + temp.data);
                    temp = temp.next;
                }
                Console.WriteLine("\t null\n");
            }
        }

        static void Main(string[] args)
        {
            HashNodeFunctions h = new HashNodeFunctions();

            h.init();
            h.insert(10);
            h.insert(4);
            h.insert(2);
            h.insert(3);
            h.insert(77);
            h.insert(5);
            h.insert(55);
            h.insert(26);
            h.insert(31);
            h.insert(54);
            h.insert(93);





            Console.WriteLine("Hash table\n");
            h.print();
            Console.WriteLine("\n");


        }
    }
}