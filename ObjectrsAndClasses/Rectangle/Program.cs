using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = StaticRectangle();
            var second = StaticRectangle();

            var result = first.isInside(second);

            Console.WriteLine(result ? "Inside" : "Not Inside");
        }

        static Rectangle StaticRectangle()
        {
            var rectangleDate = Console.ReadLine().Split(' ');

            return new Rectangle()
            {
                Left = int.Parse(rectangleDate[0]),
                Top = int.Parse(rectangleDate[1]),
                Width = int.Parse(rectangleDate[2]),
                Height = int.Parse(rectangleDate[3])
            };
        }
    }
}
