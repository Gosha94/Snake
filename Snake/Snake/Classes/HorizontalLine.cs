using System.Collections.Generic;

namespace Snake.Classes
{
    class HorizontalLine
    {
        List<Point> pointsList = new List<Point>();

        public HorizontalLine(int xLeftBorder, int xRightBorder, int y, char sym)
        {
            for(int x = xLeftBorder; x <= xRightBorder; x++)
            {
                Point point = new Point(x, y, sym);
                pointsList.Add(point);
            }
        }

        public void DrawLine()
        {
            foreach (Point point in pointsList)
            {
                point.DrawPoint();
            }
        }
    }
}
