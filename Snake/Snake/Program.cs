using System;
using Snake.Classes;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>()
            {
                new Point(0,0,'!'),
                new Point(1,1,'@'),
                new Point(2,2,'#'),
                new Point(3,3,'$'),
                new Point(4,4,'%'),
            };

            foreach(Point point in points)
            {
                point.DrawPoint();
            }

            Console.ReadLine();
        }        
    }
}
