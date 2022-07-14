using System;

namespace RectangleArea
{
    public class Rectangle
    {
        public double RectangleWidth;
        public double RectangleHeight;

        public double Area()
        {
            return RectangleWidth * RectangleHeight;
        }

        public double Perimeter()
        {
            return 2 * (RectangleWidth = RectangleHeight);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(RectangleWidth, 2) + Math.Pow(RectangleHeight, 2));
        }
    }
}
