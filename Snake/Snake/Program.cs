using System;
using Snake.Classes;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 0;
            p1.y = 0;
            p1.sym = '*';
            p1.DrawPoint();

            Point p2 = new Point();
            p2.x = 1;
            p2.y = 1;
            p2.sym = '*';
            p2.DrawPoint();

            Point p3 = new Point();
            p3.x = 2;
            p3.y = 2;
            p3.sym = '*';
            p3.DrawPoint();

            Console.ReadLine();
        }

        
    }
}
