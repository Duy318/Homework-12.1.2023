using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointinRectangle
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Point ({X},{Y})";
        }
    }
    class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public override string ToString()
        {
            return $"The rectangle contains 2 point: {TopLeft},{BottomRight}";
        }
        public bool IsContainsPoint(Point p)
        {
            bool IsCheckX = TopLeft.X <= p.X && p.X <= BottomRight.X;
            bool IsCheckY = TopLeft.Y >= p.Y && p.Y >= BottomRight.Y;
            return IsCheckX && IsCheckY;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 6);
            Console.WriteLine(p1);
            Rectangle r1 = new Rectangle(new Point(0, 2), new Point(2, 0));
            Console.WriteLine($"the Rectangle {r1} contains {p1} is {r1.IsContainsPoint(p1)}");
            Console.ReadLine();
        }
    }
}
