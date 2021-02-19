using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temperature is it?");

            string userInput = Console.ReadLine();

            int temperature = Int32.Parse(userInput);
            if(temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }else if(temperature == 10)
            {
                Console.WriteLine("It's 10 degrees C");
            }
            else
            {
                Console.WriteLine("Its cozy!");
            }

           
        }
    }
}
