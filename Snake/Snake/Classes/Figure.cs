using System.Collections.Generic;

namespace Snake.Classes
{
    class Figure
    {
        protected List<Point> pointsList;

        public virtual void Draw()
        {
            foreach (Point point in pointsList)
            {
                point.DrawPoint();
            }
        }
    }
}
