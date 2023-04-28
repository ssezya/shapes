using System;
using Shapes.Abstract;

namespace Shapes
{
    public class Triangle : Shape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("The side of a triangle cannot be less than or equal to zero.");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("It's not a triangle");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double Perimeter => _sideA + _sideB + _sideC;

        public bool IsRectangular
        {
            get
            {
                double[] sides = new double[3] { _sideA, _sideB, _sideC };
                Array.Sort(sides); // The last element will be the hypotenuse

                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
            }
        }

        protected override double CalcArea()
        {
            double semiPerimeter = Perimeter / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }
    }
}
