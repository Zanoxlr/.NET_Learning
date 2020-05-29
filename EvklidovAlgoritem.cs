using System;

namespace fkkt
{
    internal class EvklidovAlgoritem
    {
        public static void EvklidovAlgoritemMethod()
        {
            //Information
            Console.WriteLine("Insert the numbers, it will output the greatest common divisor: ");
            long num1 = Int64.Parse(Console.ReadLine());
            long num2 = Int64.Parse(Console.ReadLine());
            long remaining = 0;
            long saveRemaining;
            bool evklidovAlgoritem = true;
            //swaping inputed values so num1 has the greatest value
            if (num2 > num1)
            {
                long saveValue = num1;
                num1 = num2;
                num2 = saveValue;
            }
            while (evklidovAlgoritem)
            {
                //loop that increases the koeficient
                // on how many times does num2 multiply
                // until its value is greater then num1 
                for (long i = 1; num1 >= num2 * i; i++)
                {
                    saveRemaining = remaining;
                    remaining = num1 - (num2 * i);

                    // calculations in console
                    //Console.WriteLine("{0} = {1} * {2} + {3}", num1, num2, i, remaining);

                    // if num2 * i is greater than
                    // num1 set num1s value to num2
                    // and num2s value to remaining
                    if (num1 < num2 * i)
                    {
                        num1 = num2;
                        num2 = remaining;
                    }
                    // when the remaining = 0 end the loop
                    // and display the greatest common divisor
                    else if (remaining == 0)
                    {
                        Console.WriteLine("The greatest common divisor is : " + saveRemaining);
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