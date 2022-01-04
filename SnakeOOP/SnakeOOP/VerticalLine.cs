using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char symb)
        {
            pointlist = new List<Point>();
            for(int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, symb);
                pointlist.Add(p);
            }
        }

        
    }
}
