using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace fkkt
{
    class TextToMorse
    {
        public static void TextToMorseMethod()
        {  
            // setting all the values;
            string text, json;
            string path = @"C:\Users\Zan\Documents\TheRacerGit\CSharp_Learning\morseCode.json";
            JObject arrayJson;
            // read the json file and 
            // store it as a string
            using (StreamReader r = new StreamReader(path))
            {
                json = r.ReadToEnd();
            }
            
            // parse the string to an objec array
            arrayJson = JObject.Parse(json);

            
            // get the input text
            Console.WriteLine("Input your text: ");
            text = Console.ReadLine();
            // find the morse code for the characters
            for (int letter = 0; letter < text.Length; letter++)
            {
                Console.Write(arrayJson[text[letter].ToString()]);
            }
            // find the characters for the morse code
            for (int letter = 0; letter < text.Length; letter++)
            {
                Console.Write(arrayJson[text[letter].ToString()].GetType().Name);
            }
        }
    }
}