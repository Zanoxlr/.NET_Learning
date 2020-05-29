using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace fkkt
{
    internal class TextToMorse
    {
        public static void TextToMorseMethod()
        {
            // setting all the values;
            string text, returnText = "";
            // get the input text
            Console.WriteLine("Input your text: ");
            text = Console.ReadLine();

            // get characters converted into
            //  morse and outputs the result
            returnText = TextToMorseFor(text);
            Console.WriteLine(returnText);
        }

        public static string TextToMorseFor(string text)
        {
            // get morse aplhabet as a Json object
            JObject arrayJson = GetMorseAlphabet();
            // set a blank string
            string returnText = "";
            // find the morse code for each character
            for (int letter = 0; letter < text.Length; letter++)
            {
                returnText += arrayJson[text[letter].ToString()];
            }
            return returnText;
        }

        public static JObject GetMorseAlphabet()
        {
            // setting all the values;
            string json;
            string path = @"C:\Users\Zan\Documents\Git\CSharp_Learning\morseCode.json";
            // read the json file and
            // store it as a string
            using (StreamReader r = new StreamReader(path))
            {
                json = r.ReadToEnd();
            }
            // parse the string to an objec array
            return JObject.Parse(json);
        }
    }
}