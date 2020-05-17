using System.Collections.Generic;

namespace Snake.Classes
{
    class Figure
    {
        protected List<Point> pointsList;

        public void DrawLine()
        {
            foreach (Point point in pointsList)
            {
                point.DrawPoint();
            }
        }
    }
}
