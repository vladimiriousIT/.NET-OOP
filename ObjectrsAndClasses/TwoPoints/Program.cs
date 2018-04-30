using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPoints
{
    class Program
    {
        static void Main()
        {
            var firstPointData = ReadPoint();
            var secondPointData = ReadPoint();
            var result = Distance(firstPointData, secondPointData);

            Console.WriteLine(result);
        }

        static Points ReadPoint()
        {
            var pointData = Console.ReadLine().Split(' ');
            var point = new Points
            {
                PointX = int.Parse(pointData[0]),
                PointY = int.Parse(pointData[1])
            };

            return point;

        }
        static double Distance(Points first, Points second)
        {
            var xDiv = first.PointX - second.PointX;
            var xSquare = xDiv * xDiv;
            var ydiv = first.PointY - second.PointY;
            var ySquare = ydiv * ydiv;

            return Math.Sqrt(xSquare + ySquare);
        }

    }
}
