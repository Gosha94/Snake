using Snake.Enums;

using System;

namespace Snake.Classes
{
    class Point
    {
        /*
        private int x;
        private int y;
        private char sym;
        */
        public int x;
        public int y;
        public char sym;

        public Point() { }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public Point( int x, int y, char sym )
        {
            this.x = x;
            this.y = y;
            this.sym = sym;

            //DrawPoint();
        }

        public void Move( int offset, Direction direction)
        {
            if (direction == Direction.Right) x = x + offset;
            if (direction == Direction.Left) x = x - offset;
            if (direction == Direction.Up) y = y - offset;
            if (direction == Direction.Down) y = y + offset;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition( x, y );
            Console.Write( sym );
        }

        public override string ToString()
        {
            return x + " , " + y + " , " + sym;
        }

        public void Clear()
        {
            sym = ' ';
            DrawPoint();
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
