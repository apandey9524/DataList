using System;

namespace DataList
{
    public class KeyBoardInput
    {
        public char GetChar()
        {
            return Console.ReadKey().KeyChar;
        }
    }
}