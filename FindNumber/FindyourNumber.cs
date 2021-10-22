using System;

namespace GuessNumber
{
    class guessnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter if number is between 0-N :");
            int num = Convert.ToInt32(Console.ReadLine());
            int mid = num / 2;
            
            while (true)
            {
                int count = 1;
                Console.Write("Enter a number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                while (num !=0)
                {
                    
                    if (number == 0)
                        return;
                    else if (number < mid && number > 0)
                    {
                        Console.WriteLine("is it between 0-n/2..Low ..Pease give answer yes  or no:");
                        string ans = Console.ReadLine();
                        if(ans == "y" || ans== "Y"||  ans=="yes" || ans=="YES")
                        {
                            while( number == count)
                            {
                                count++;
                            }

                            Console.WriteLine("Found Number " +number);
                        }
                        break;
                    }
                    else if (number > mid && number > 0)
                    {
                        Console.WriteLine("High, is it between n/2-N. Pease give answer yes  or no: ");
                        string ans = Console.ReadLine();

                        if (ans == "y" || ans == "Y" || ans == "yes" || ans == "YES")
                        {
                            while (number == count)
                            {
                                count++;
                            }

                            Console.WriteLine("Found Number " + number);
                            break;
                        }
                       
                    }
                    
                }
                break;
            }

        }
        
    }
}
