using System;
using System.Collections.Generic;
using System.Linq;
using TextScrambler.Scrambler;

namespace TextScrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting text scrambling test");

            var scrambler = new StringScrambler();
            var seed = "This is a seed";

            var textList = new string[] 
            {
                "test",
                "sample",
                "test sample",
                "sample test",
                "asdf sample test 323423 @#$#@dfsd df",
                "teetw sdfds.dsf sfdfsdf #@#$32 sdfsf fdsfs"
            };

            var skipChars = new List<char> { ' ', '$'};
            var outputChars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().ToList();

            WriteDataTableHeader("Text", "Scrambled Text");
            foreach (var text in textList)
            {
                var scrambledText = scrambler.Scramble(seed, text, skipChars, outputChars);
                WriteDataTableRow(text, scrambledText);
            }

            Console.WriteLine("Completed text scrambling test");

            Console.ReadLine();
        }

        private static void WriteDataTableHeader(string header1, string header2)
        {
            Console.WriteLine($"|{header1}|{header1}-Length|{header2}|{header2}-Length|");
            Console.WriteLine($"|-----------|-----------|-----------|-----------|");
        }

        private static void WriteDataTableRow(string text, string scrambledText)
        {
            Console.WriteLine($"|{text}|{text.Length}|{scrambledText}|{scrambledText.Length}|");
        }
    }
}
