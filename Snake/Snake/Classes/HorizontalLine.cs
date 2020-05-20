using System;
using System.Collections.Generic;

namespace Snake.Classes
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeftBorder, int xRightBorder, int y, char sym)
        {
            pointsList = new List<Point>();

            for(int x = xLeftBorder; x <= xRightBorder; x++)
            {
                Point point = new Point(x, y, sym);
                pointsList.Add(point);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Point p in pointsList) p.DrawPoint();
            // base.Draw();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
