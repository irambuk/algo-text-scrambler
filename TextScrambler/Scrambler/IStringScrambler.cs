
using System;
using System.Collections.Generic;
using System.Text;

namespace TextScrambler.Scrambler
{
    public interface IStringScrambler
    {
        string Scramble(string seedText, int seedInt, string text, List<char> scrambleSkipChars, List<char> scrambledOutputChars);
    }
}
