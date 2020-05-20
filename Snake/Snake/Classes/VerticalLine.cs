using System;
using System.Collections.Generic;

namespace Snake.Classes
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yTopBorder, int yDownBorder, int x, char sym)
        {
            pointsList = new List<Point>();

            for (int y = yTopBorder; y <= yDownBorder; y++)
            {
                Point point = new Point(x, y, sym);
                pointsList.Add(point);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (Point p in pointsList) p.DrawPoint();
            // base.Draw();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
