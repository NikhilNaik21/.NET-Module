using System;
using System.Collections;

namespace Revision
{


    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Nikhil");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            Point p1 = new Point(1, 2);
            Point p2 = new Point(2, 3);
            Point result = p1 + p2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
   

