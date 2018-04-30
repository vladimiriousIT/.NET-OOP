
namespace Rectangle
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Rigth
        {
            get
            {
                return Left + Width;
            }
        }
        public int CalculateArea()
        {
            return Width * Height; 
        }
        public bool isInside (Rectangle other)
        {
            return Left >= other.Left && Rigth <= other.Rigth && Bottom <= other.Bottom && Top>= other.Top;
        }
    }
}
