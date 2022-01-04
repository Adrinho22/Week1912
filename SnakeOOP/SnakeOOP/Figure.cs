using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Figure
    {
        protected List<Point> pointlist;
        
        public void Draw()
        {
            foreach (Point point in pointlist)
            {
                point.Draw();
            }
        }
    }
}
