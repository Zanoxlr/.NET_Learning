using System;
using System.Collections.Generic;
using System.Text;

namespace fkkt
{
    class TextToBinary
    {
        public static void TextToBinaryMethod()
        {
            string text = "No text";
            Console.WriteLine("Input your text: ");
            text = Console.ReadLine();

            for (int letter = 0; letter < text.Length; letter++)
            {
                if (Convert.ToString(text[letter]) == "a")
                {
                    Console.Write(".- ");
                }
                else if (Convert.ToString(text[letter]) == "b")
                {
                    Console.Write("-... ");
                }
                else if (Convert.ToString(text[letter]) == "c")
                {
                    Console.Write("-.-. ");
                }
                else if (Convert.ToString(text[letter]) == "d")
                {
                    Console.Write("-.. ");
                }
                else if (Convert.ToString(text[letter]) == "e")
                {
                    Console.Write(". ");
                }
                else if (Convert.ToString(text[letter]) == "f")
                {
                    Console.Write("..-. ");
                }
                else if (Convert.ToString(text[letter]) == "g")
                {
                    Console.Write("--. ");
                }
                else if (Convert.ToString(text[letter]) == "h")
                {
                    Console.Write(".... ");
                }
                else if (Convert.ToString(text[letter]) == "i")
                {
                    Console.Write(".. ");
                }
                else if (Convert.ToString(text[letter]) == "j")
                {
                    Console.Write(".---");
                }
                else if (Convert.ToString(text[letter]) == "k")
                {
                    Console.Write("-.- ");
                }
                else if (Convert.ToString(text[letter]) == "l")
                {
                    Console.Write(".-.. ");
                }
                else if (Convert.ToString(text[letter]) == "m")
                {
                    Console.Write("-- ");
                }
                else if (Convert.ToString(text[letter]) == "n")
                {
                    Console.Write("-. ");
                }
                else if (Convert.ToString(text[letter]) == "o")
                {
                    Console.Write("---");
                }
                else if (Convert.ToString(text[letter]) == "p")
                {
                    Console.Write(".--. ");
                }
                else if (Convert.ToString(text[letter]) == "r")
                {
                    Console.Write(".-. ");
                }
                else if (Convert.ToString(text[letter]) == "s")
                {
                    Console.Write("... ");
                }
                else if (Convert.ToString(text[letter]) == "t")
                {
                    Console.Write("- ");
                }
                else if (Convert.ToString(text[letter]) == "u")
                {
                    Console.Write("..- ");
                }
                else if (Convert.ToString(text[letter]) == "v")
                {
                    Console.Write("...- ");
                }
                else if (Convert.ToString(text[letter]) == "w")
                {
                    Console.Write(".-- ");
                }
                else if (Convert.ToString(text[letter]) == "x")
                {
                    Console.Write("-..- ");
                }
                else if (Convert.ToString(text[letter]) == "y")
                {
                    Console.Write("-.-- ");
                }
                else if (Convert.ToString(text[letter]) == "z")
                {
                    Console.Write("--.. ");
                }
                else if (Convert.ToString(text[letter]) == "1")
                {
                    Console.Write(".---- ");
                }
                else if (Convert.ToString(text[letter]) == "2")
                {
                    Console.Write("..--- ");
                }
                else if (Convert.ToString(text[letter]) == "3")
                {
                    Console.Write("...-- ");
                }
                else if (Convert.ToString(text[letter]) == "4")
                {
                    Console.Write("....- ");
                }
                else if (Convert.ToString(text[letter]) == "5")
                {
                    Console.Write("..... ");
                }
                else if (Convert.ToString(text[letter]) == "6")
                {
                    Console.Write("-.... ");
                }
                else if (Convert.ToString(text[letter]) == "7")
                {
                    Console.Write("--...");
                }
                else if (Convert.ToString(text[letter]) == "8")
                {
                    Console.Write("---.. ");
                }
                else if (Convert.ToString(text[letter]) == "9")
                {
                    Console.Write("----. ");
                }
                else if (Convert.ToString(text[letter]) == "0")
                {
                    Console.Write("----- ");
                }
            }
        }
    }
}