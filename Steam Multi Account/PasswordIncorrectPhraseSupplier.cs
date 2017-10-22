using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Multi_Account
{
    class PasswordIncorrectPhraseSupplier
    {
        private static string[] _Phrases = new string[]
        {
            "Password incorrect",
            "Password still incorrect",
            "Give up!",
            "You wont get in",
            "stop",
            "no chance",
            "this is a waste of time",
            "maybe you would stop if this message wouldnt change",
            "maybe you would stop if this message wouldnt change",
            "maybe you would stop if this message wouldnt change",
            " >:( ",
            "Lets try again"
        };

        private int _Index;

        public string GetPasswordIncorrectPhrase()
        {
            string phrase = _Phrases[_Index];
            _Phrases[_Index] += "!";

            _Index = (_Index + 1) % _Phrases.Length;

            return phrase;
        }
    }
}
