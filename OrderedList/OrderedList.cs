using System;
using System.IO;

namespace OrderedLinkedList
{
    public class Node
    {
        public string data;
        public Node next;

        public Node()
        {
        }

        public Node(string data)
        {
            this.data = data;
        }
    }

    class OrderedList
    {
        internal Node head;
        public static void Main(string[] args)
        {


            OrderedList obj = new OrderedList();
            string path = @"E:\dotnet\DataStructure\Algorithms\OrderedLinkedList\TextFile.txt";

            FileStream file = null;
            StreamReader reader = null;
            string filecontent = String.Empty;

            char[] space = { ' ' };

            if (File.Exists(path))
            {
                file = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("file does not exist");
                return;
            }
            try
            {
                reader = new StreamReader(file);
                filecontent = reader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured");

            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            string[] words = filecontent.Split(space);

            Console.WriteLine("Before insering into linkedlist file contents :");

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("Inserting from file into linkedlist  into sorted order:\n");


            for (int i = 0; i < words.Length; i++)
            {

                obj.List(words[i]);

            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("file content :\n");
            obj.Display();
            Console.WriteLine("\n -----------------------------------------");
            
            Console.WriteLine("Appending to file inserting from linkedlist :\n");

            Console.WriteLine(" Enter Number to add into file :\n");
            string number = Console.ReadLine();
            string createText = number + Environment.NewLine;
            File.AppendAllText(path, number);
            obj.List(number);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("file content After appending  :\n");
            obj.Display();
            
            
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(" \n Size of linkedlist :\n");

            obj.getsize();

            Console.WriteLine("-----------------------------------------");
            
            Console.WriteLine(" Search Number   :\n");
            string searchfruit = Console.ReadLine();
            var check = obj.Search(searchfruit);

            if (check != null)
            {

                Console.WriteLine("Found Data !! " + searchfruit);

            }
            else
            {
                Console.WriteLine(" Data not found !!");
            }
        }

        public void List(string data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                // insert in head if x is lower than the head
            }
            else if (head.data.CompareTo(data)>0)
            {
                newnode.next = head;
                head = newnode;
            }
            else
            {
                // find the first node which value is lower than x (or the tail)
                Node current;
                for (current = head; current.next != null && current.next.data.CompareTo(data) < 0; current = current.next) ;
                
                    // to remove duplicates
                    if (data != current.data)
                    {
                        newnode.next = current.next;
                        current.next = newnode;
                    }
                


            }
        }





        internal void Display()
        {

            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;


            }

        }

        internal void getsize()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                temp = temp.next;

                count++;
            }
            Console.WriteLine("\nSize of Linked list = " + count);


        }
        internal Node Search(string value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;

                }
                this.head = this.head.next;
            }
            return null;

        }


    }

}

