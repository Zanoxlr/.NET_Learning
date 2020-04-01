using System;
using System.Collections.Generic;
using System.Text;

namespace fkkt
{
    class CoinRepeat
    {
        public static void CoinRepeatMethod()
        {
            int rnum = 0;
            int storeValue = 0;
            int countR = 0;
            int asd = 0;

            Console.WriteLine("0 al 1");
            int countKovanc = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Koliko");
            int countRound = Int32.Parse(Console.ReadLine());

            while (true)
            {
                storeValue = rnum;
                Random rnd = new Random();
                rnum = rnd.Next(0, 2);
                countR = countR + 1;

                if ((countKovanc == rnum) && (rnum == storeValue))
                {
                    if (asd > 10) { Console.WriteLine(asd); }
                    asd = asd + 1;
                    if (asd == countRound)
                    {
                        Console.WriteLine("Uspelo je po {0} poskusih");
                        break;
                    }
                }
                else
                {
                    asd = 0;
                }
            }
        }
    }
}
