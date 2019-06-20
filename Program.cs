using System;

namespace Vixer
{
    class Program
    {
        static void Main(string[] args)
        {


            /*string secret = "Zebra";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            while(guess != secret && !outOfGuess )
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("enter another guess");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuess = true;

                }
                if (outOfGuess)
                {
                    Console.WriteLine("You loose");
                }
                 
            } */

            int[] luckynumbers = { 1, 2, 2, 3, 3, 4, 5 };
            for (int i=0; i < luckynumbers.Length ; i++)
            {
                Console.WriteLine(luckynumbers[i]);
            }


        }

    }


}
