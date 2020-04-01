using System;
using System.Collections.Generic;
using System.Text;

namespace fkkt
{
    class EvklidovAlgoritem
    {
        public static void EvklidovAlgoritemMethod()
        {
            //Information
            Console.WriteLine("Vpiši deljitelja, izpisal bom najvecjega skupnega deljitelja teh dveh št.");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int remaining = 0;
            int saveRemaining;
            bool evklidovAlgoritem = true;
            //swaping inputed values so num1 has the greatest value
            if (num2 > num1)
            {
                int saveValue = num1;
                num1 = num2;
                num2 = saveValue;
            }
            while (evklidovAlgoritem)
            {
                //loop that increases the koeficient
                for (int i = 1; num1 >= num2 * i; i++)
                {
                    saveRemaining = remaining;
                    remaining = num1 - (num2 * i);
                    Console.WriteLine(num1 + " = " + num2 + " * " + i + " + " + remaining);
                    if (num1 < num2 * i)
                    {
                        num1 = num2;
                        num2 = remaining;
                    }
                    else if (remaining == 0)
                    {
                        Console.WriteLine("Najmanjsi skupni deljitelj je: " + saveRemaining);
                        evklidovAlgoritem = false;
                    }
                    else if (remaining < num2)
                    {
                        num1 = num2;
                        num2 = remaining;
                    }
                }
            }
        }
    }
}