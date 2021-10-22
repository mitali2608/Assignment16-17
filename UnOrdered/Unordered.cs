using System;
using System.IO;

namespace UnorderedLinkList
{
    public class Node
    {
       public string data;
       public  Node next;

        public Node()
        {
        }

        public Node(string data)
        {
            this.data = data;
        }
    }
    
    class Unordered
    {
        internal Node head;
        public static void Main(string[] args)
        {


            Unordered obj = new Unordered();
            string path = @"E:\dotnet\DataStructure\Algorithms\Datastructure2\TextFile.txt";

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




            Console.WriteLine("Inserting ifrom file into linklist :\n");


            for (int i = 0; i < words.Length; i++)
            {

                obj.List(words[i]);

            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("file content :\n");
            obj.Display();
            Console.WriteLine("\n -----------------------------------------");

            Console.WriteLine("Appending to file inserting from linkedlist :\n");

            Console.WriteLine(" Enter Fruit name to add into file :\n");
            string fruit = Console.ReadLine();

            string createText = fruit + Environment.NewLine;
            File.AppendAllText(path, fruit);
            obj.List(fruit);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("file content After appending  :\n");
            obj.Display();

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine(" Size of linkedlist :\n");
            obj.getsize();

            Console.WriteLine("-----------------------------------------");


            Console.WriteLine(" Search fruit name  :\n");
            string searchfruit = Console.ReadLine();
            var check=obj.Search(searchfruit);

            if (check !=null)
            {

                Console.WriteLine("Found Node !! " + searchfruit);

            }
            else
            {
                Console.WriteLine(" Data not found !!");
            }

        }

        public void List(string data )
        {

            Node node = new Node(data);


                if (this.head == null)
                    this.head = node;
                else
                {
                    Node temp = head;

                while (temp.next != null)
                {
                   temp = temp.next;
                }

                    temp.next = node;
                }

                Console.WriteLine(node.data);
           
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
                Console.Write(temp.data + " " );
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
            Console.WriteLine("\nSize of Linked list = "+count);


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

