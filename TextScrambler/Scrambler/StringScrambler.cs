using System;
using System.Collections.Generic;
using System.Text;

namespace TextScrambler.Scrambler
{
    public class StringScrambler : IStringScrambler
    {
        public string Scramble(string seed, string text, List<char> scrambleSkipChars, List<char> scrambledOutputChars)
        {
            if (string.IsNullOrWhiteSpace(seed) || string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Given seed or text is not valid.");
            }

            var buffer = new StringBuilder();

            //Process one char at a time
            var textChars = text.ToCharArray();
            for (int i = 0; i < textChars.Length; i++)
            {
                var textChar = textChars[i];
                buffer.Append(ScrambleChar(seed, textChar, i, scrambleSkipChars, scrambledOutputChars));
            }

            return buffer.ToString();
        }

        private char ScrambleChar(string seed, char textChar, int textCharPosition, List<char> scrambleSkipChars, List<char> scrambledOutputChars)
        {
            if (scrambleSkipChars.Contains(textChar))
            {
                return textChar;
            }

            var current = (int)textChar * textCharPosition;

            //Process the given char for each char in the seed
            foreach (var seedChar in seed.ToCharArray())
            {
                //Find the operation: 0 -> add, 1 -> minus, 2 -> multiply
                var seedCharInt = (int)seedChar;
                var operation = seedCharInt % 3;                

                switch (operation)
                {
                    case 0:
                        current += seedCharInt;
                        break;
                    case 1:
                        current -= seedCharInt;
                        break;
                    case 2:
                        current *= seedCharInt;
                        break;
                    default:
                        throw new NotSupportedException("Given operation is not supported");
                }
            }

            var charPosition = Math.Abs(current) % scrambledOutputChars.Count;

            return scrambledOutputChars[charPosition];
        }
    }
}
