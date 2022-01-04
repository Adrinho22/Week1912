using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class HorizontalLine : Figure
    {
        
        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pointlist = new List<Point>();

            for(int i = xLeft; i<= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pointlist.Add(p);
            }

            //Point p1 = new Point(6, 6, '#');
            //Point p2 = new Point(7, 6, '#');
            //Point p3 = new Point(8, 6, '#');

            //pointlist.Add(p1);
            //pointlist.Add(p2);
            //pointlist.Add(p3);
        }
        
        
    }
}
