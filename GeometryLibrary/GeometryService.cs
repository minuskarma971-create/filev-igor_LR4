using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GeometryLibrary
{
    public class GeometryService : IGeometryService
    {
        public double RectangleArea(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new GeometryException("Стороны прямоугольника должны быть больше нуля.");
            return width * height;
        }
        public double RectanglePerimeter(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new GeometryException("Стороны прямоугольника должны быть больше нуля.");
            return 2 * (width + height);
        }
        public double CircleArea(double radius)
        {
            if (radius <= 0)
                throw new GeometryException("Радиус круга должен быть больше нуля.");
            return Math.PI * radius * radius;
        }
        public double CircleCircumference(double radius)
        {
            if (radius <= 0)
                throw new GeometryException("Радиус круга должен быть больше нуля.");
            return 2 * Math.PI * radius;
        }
    }
}
