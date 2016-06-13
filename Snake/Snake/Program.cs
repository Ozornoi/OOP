using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;

        }

        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            p1.Draw();

            Point p2 = new Point(4, 5, '#');

            p2.Draw();



            HorizontalLine line = new HorizontalLine(5, 25, 8, '&');
            line.Drow();
            verticalLine line1 = new verticalLine(10, 15, 6, '@');
            line1.Drow();
            Console.ReadLine();
        }
        
    }
}
