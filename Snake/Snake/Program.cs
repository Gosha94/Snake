using System;
using Snake.Classes;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();

            Point p2 = new Point( 1, 1, '^' );

            Point p3 = new Point(2, 2, '*');

            Point p4 = new Point(3, 3, '$');

            Console.ReadLine();
        }        
    }
}
