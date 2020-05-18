using System.Collections.Generic;

namespace Snake.Classes
{
    class Figure
    {
        protected List<Point> pointsList;

        public void Draw()
        {
            foreach (Point point in pointsList)
            {
                point.DrawPoint();
            }
        }
    }
}
