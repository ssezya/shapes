using System;

namespace Shapes.Abstract
{
    public abstract class Shape
    {
        private readonly Lazy<double> _area;

        public double Area => _area.Value;

        public Shape()
        {
            _area = new Lazy<double>(CalcArea);
        }

        protected abstract double CalcArea();
    }
}
