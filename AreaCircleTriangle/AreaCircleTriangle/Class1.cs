using System;
using System.Collections.Generic;
namespace AreaCircleTriangle
{
    public class Class1
    {
        static double square = 0;
        static double Pi = 3.14;
        static double DataEntry(List<int> ShapeParameters)
        {
            square = 0;
            if (ShapeParameters.Count == 1) square = SquareCircle(ShapeParameters);
            if (ShapeParameters.Count == 3)
            {
                bool rightTriangle = RightTriangle(ShapeParameters);
                square = SquareTriangle(ShapeParameters);
            }

            return square;
        }
        static double SquareCircle(List<int> ShapeParameters)
        {
            square = Pi * ShapeParameters[0] * 2;
            return square;
        }
        static double SquareTriangle(List<int> ShapeParameters)
        {
            double p = (ShapeParameters[0] + ShapeParameters[1] + ShapeParameters[2]) / 2;
            square = Math.Sqrt(p * (p - ShapeParameters[0]) * (p - ShapeParameters[1]) * (p - ShapeParameters[2]));
            return square;
        }
        static bool RightTriangle(List<int> ShapeParameters)
        {
            bool rightTriangle = false;
            if ((ShapeParameters[0] * ShapeParameters[0] + ShapeParameters[1] * ShapeParameters[1] == ShapeParameters[2] * ShapeParameters[2]) || (ShapeParameters[0] * ShapeParameters[0] + ShapeParameters[2] * ShapeParameters[2] == ShapeParameters[1] * ShapeParameters[1]) || (ShapeParameters[2] * ShapeParameters[2] + ShapeParameters[1] * ShapeParameters[1] == ShapeParameters[0] * ShapeParameters[0])) rightTriangle = true;
            return rightTriangle;
        }
    }
}