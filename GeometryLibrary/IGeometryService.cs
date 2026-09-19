using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GeometryLibrary
{
    public interface IGeometryService
    {
        double RectangleArea(double width, double height);
        double RectanglePerimeter(double width, double height);
        double CircleArea(double radius);
        double CircleCircumference(double radius);
    }
}
