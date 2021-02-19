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


           
        }
    }
}
