using System;
using Shapes.Abstract;

namespace Shapes
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public double Radius => _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius of the circle cannot be less than or equal to zero.");

            _radius = radius;
        }

        protected override double CalcArea() => Math.PI * Math.Pow(_radius, 2);
    }
}
