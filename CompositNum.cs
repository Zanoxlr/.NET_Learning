using System;
using System.Collections.Generic;
using System.Text;

namespace fkkt
{
    class CompositNum
    {
        public static void CompositNumMethod()
        {
            Console.WriteLine("Input a number, if it is a composit number, it's value is going to be incresed by one.");
            int arraySize = Int32.Parse(Console.ReadLine());
            if(arraySize % 2 == 0)
            {
                arraySize += 1;
            }
            int counter = 0;
            while (true)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    if (i == (arraySize - 1) / 2)
                    {
                        Console.Write(arraySize + counter + " ");
                    }
                    else if (i != (arraySize - 1) / 2)
                    {
                        Console.Write(0+ " ");
                    }
                }
                Console.WriteLine("");
                counter += 1;
                if (counter == arraySize)
                {
                    break;
                }
            }
        }
    }
}
