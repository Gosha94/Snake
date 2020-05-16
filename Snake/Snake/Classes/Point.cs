using System;

namespace Snake.Classes
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public void DrawPoint()
        {
            Console.SetCursorPosition( x, y );
            Console.Write( sym );
        }
    }
}
