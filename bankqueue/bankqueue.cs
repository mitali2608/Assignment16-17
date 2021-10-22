using System;

namespace Queue
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
        }

        public Node(int data)
        {
            this.data = data;
        }

    }
    class bankqueue
    {
       
        internal Node head;

        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to bank cash counter!\n");
            bankqueue q = new bankqueue();
            Console.WriteLine("People in queue :");

            // int[] people = new int[5];
            for (int i = 1; i < 5; i++)
            {
                q.enqueue(i);

                int totalBalance = 50000;
                int depositAmount = 0;
                int withdrawAmount = 0;

                int option;


                Console.WriteLine("######### Bank Service##########\n");
                Console.WriteLine("1. Cash Withdrawal Counter\n");
                Console.WriteLine("2. Deposit your Cash Counter\n");
                Console.WriteLine("3. Exit\n");
                Console.WriteLine("#####################################\n\n");
                Console.Write("Select Service : ");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {


                    case 1:
                        Console.Write("\nYour Total Account Balanace : " + totalBalance);

                        Console.Write("\nEnter withdrawal amount: ");
                        withdrawAmount = int.Parse(Console.ReadLine());

                        if (withdrawAmount > totalBalance)
                        {
                            Console.WriteLine("\nIn-sufficient balance in your account");
                        }
                        else
                        {
                            totalBalance = totalBalance - withdrawAmount;
                            Console.WriteLine("\n\nPlease collect your money");
                            Console.WriteLine("\nYour remaining balance is: " + totalBalance);
                        }
                        q.dequeue();

                        break;
                    case 2:
                        Console.Write("\nYour Total Account Balanace : " + totalBalance);

                        Console.Write("\nEnter amount to deposit: ");
                        depositAmount = int.Parse(Console.ReadLine());
                        totalBalance = totalBalance + depositAmount;
                        Console.WriteLine("Your current balance: " + totalBalance);
                        q.dequeue();

                        break;
                    case 3:
                        q.dequeue();
                                 break;
                }

                
                Console.WriteLine("\n\nThank You!");
                Console.WriteLine(" ------------------------");

            }
        }





        //Adding Node to queue
        internal void enqueue(int data)
        {
            Node newnode = new Node(data);

            if (head == null)
            {
                head = newnode;
            }
            else
            {

                Node temp = new Node(data);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newnode;

            }
            Console.WriteLine("\n {0} Customer added to Queue", newnode.data);
            Console.WriteLine(" ");

        }


        //Removing node from queue 
        internal void dequeue()
        {

            if (head == null)
            {
                Console.WriteLine(" Cant perform delete operation ");
            }
            else
            {
                while (head != null)
                {
                    Node temp = head;
                    Console.WriteLine("\n" + temp.data + " Customer left Queue ");

                    head = head.next;
                    temp = null;
                }
                Console.WriteLine(" ------------------------");

                
            }
        }






    }
}
