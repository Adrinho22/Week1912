using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeOOP
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            pointlist = new List<Point>();
            direction = _direction;
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointlist.Add(p);
            }

        }

        public void Move()
        {
            Point tail = pointlist.First();
            pointlist.Remove(tail);
            tail.Clear();

            Point head = GetNextPoint();
            pointlist.Add(head);
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pointlist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
