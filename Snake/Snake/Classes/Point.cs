using System;

namespace Snake.Classes
{
    class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point() { }
        public Point( int x, int y, char sym )
        {
            this.x = x;
            this.y = y;
            this.sym = sym;

            DrawPoint();
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition( x, y );
            Console.Write( sym );
        }
    }
}
