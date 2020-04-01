using System;
using System.Collections.Generic;
using System.Text;

namespace fkkt
{
    class Gondole
    {
        public static void GondoleMethod()
        {
            int mulit = 2;
            int gondole = 0;
            while (true)
            {
                gondole += 1;
                if (gondole == 101)
                {
                    gondole = 0;
                }
                else if (gondole % 2 != 0)
                {

                    System.Threading.Thread.Sleep(460 * mulit);
                    Console.WriteLine("Gondola " + gondole + " se odpira");
                    System.Threading.Thread.Sleep(540 * mulit);
                    Console.WriteLine("Gondola " + gondole + " se zapre");
                    continue;
                }
                else if (gondole % 2 == 0)
                {
                    System.Threading.Thread.Sleep(600 * mulit);
                    Console.WriteLine("Gondola " + gondole + " se odpira");
                    System.Threading.Thread.Sleep(400 * mulit);
                    Console.WriteLine("Gondola " + gondole + " se zapre");
                    continue;
                }
            }
        }
    }
}