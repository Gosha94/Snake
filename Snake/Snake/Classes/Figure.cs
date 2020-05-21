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

        internal bool IsHit( Figure figure )
        {
            foreach ( var p in pointsList )
            {
                if ( figure.IsHit( p ) ) return true;
            }
            return false;
        }

        private bool IsHit( Point point)
        {
            foreach (var p in pointsList)
            {
                if ( p.IsHit( point ) ) return true;
            }
            return false;
        }
    }
}
