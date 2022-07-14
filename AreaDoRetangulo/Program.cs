using System;
using System.Globalization;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            rectangle.RectangleWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.RectangleHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nÁREA = {rectangle.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nPERÍMETRO = {rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nDIAGONAL = {rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}