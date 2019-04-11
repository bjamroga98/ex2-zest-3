using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_zest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I feel it in my fingers";
            int counted = CountWords(text);

            Console.WriteLine("Text: " + text);
            Console.WriteLine("Words count:" + counted);

            Console.ReadKey();
        }
        static int CountWords(string text)
        {
            // Split the original text into strings and then count their number
            string[] textAsArray = text.Split(' ');
            return textAsArray.Length;
        }
    }
}
