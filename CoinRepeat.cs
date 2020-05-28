using System;
using System.Collections.Generic;
using System.Text;

namespace fkkt
{
    class CoinRepeat
    {
        public static void CoinRepeatMethod()
        {
            // set the variables
            int randomNum = 0;
            int storeValue = 0;
            int countR = 0;
            int roundCounterMatches = 0;
            Random rnd = new Random();
            // get the input data
            Console.WriteLine("0 or 1");
            int coinWantedValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many times do you want it to repeat? :");
            int countRound = Int32.Parse(Console.ReadLine());

            while (true)
            {
                // save the previous random number
                storeValue = randomNum;
                // set a random number 0 or 1
                randomNum = rnd.Next(0, 2);
                // increase the round counter
                countR++;
                // check if wanted coin value is the same
                // as this and last rounds number 
                if ((coinWantedValue == randomNum) && (randomNum == storeValue))
                {
                    // if the counter is over 10
                    // write it to the console
                    if (roundCounterMatches > 10) { Console.WriteLine(roundCounterMatches); }
                    // increase the round counter matches by one
                    roundCounterMatches++;
                    // if the counter matches the rounds required 
                    // it will write to the console and break the loop
                    if (roundCounterMatches == countRound)
                    {
                        Console.WriteLine("It took {0} trys",countR);
                        break;
                    }
                }
                else
                {
                    // restart the round couter
                    roundCounterMatches = 0;
                }
            }
        }
    }
}
