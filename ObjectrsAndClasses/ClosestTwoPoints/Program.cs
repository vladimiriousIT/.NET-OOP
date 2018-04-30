using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPoint = int.Parse(Console.ReadLine());
            var allPoint = new List<Points>();
           
            var minDistance = double.MaxValue;
            Points minFirstPoint = null;
            Points minSecondPoint = null;

            for (int i = 0; i < numberPoint; i++)
            {
                var currentPoint = ReadPoint();
                allPoint.Add(currentPoint);
            }

            for (int i = 0; i < numberPoint; i++)
            {
                for (int j = i + 1; j < numberPoint; j++)
                {
                    var firstPoint = allPoint[i];
                    var secondPoint = allPoint[j];
                    var currDistance = Distance(firstPoint, secondPoint);

                    if (currDistance < minDistance)
                    {
                        minDistance = currDistance;
                        minFirstPoint = firstPoint;
                        minSecondPoint = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(minFirstPoint.Display());
            Console.WriteLine(minSecondPoint.Display());
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
