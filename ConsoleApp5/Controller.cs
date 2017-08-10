using System;
using System.Collections.Generic;
using System.Threading;

namespace DataList
{
    class Controller
    {
        string CurrentNameValue { get; set; }
        public IHintProvider HintProvider { get; private set; }
        private string _result;
        public void GetHintProvider()
        {
            char nextChar = new KeyBoardInput().GetChar();
            //if (nextChar != (char)27)
            {
                HintProvider = HintProvider.GetHint(nextChar, out _result);
                Display.DisplayOnConsole(CurrentNameValue);
            }
        }

    }
}
