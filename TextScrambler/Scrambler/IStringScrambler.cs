
using System;
using System.Collections.Generic;
using System.Text;

namespace TextScrambler.Scrambler
{
    public interface IStringScrambler
    {
        string Scramble(string seed, string text);
    }
}
