using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temperature is it?");

            string tempInput = Console.ReadLine();
            int numTemp;
            int number;

            //can also do "bool enteredNum = int.TryParse(temperature, out number)"
            //then use if(enteredNum){}

            if (int.TryParse(tempInput, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }

            if(numTemp < 10)
            {
                Console.WriteLine("Take the coat");
            }else if(numTemp == 10)
            {
                Console.WriteLine("It's 10 degrees C");
            }
            else
            {
                Console.WriteLine("Its cozy!");
            }

            //nested if statements

            Console.WriteLine("Please enter your username:");
            bool isAdmin = false;
            bool isRegistered = true;
            string username = "";
            username = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, User!");
                if(username != "")
                {
                    Console.WriteLine("Hi there, {0}", username);
                    if (username.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, admin!");
                    }
                }
                
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in.");
            }
           
        }
    }
}
