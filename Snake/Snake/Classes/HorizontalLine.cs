﻿using System.Collections.Generic;

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
    }
}
