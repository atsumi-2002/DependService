using System;
using System.Collections.Generic;
using System.Text;

namespace DependService
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
