using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 10;
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
