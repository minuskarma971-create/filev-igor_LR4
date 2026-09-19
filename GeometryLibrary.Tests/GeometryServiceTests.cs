using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GeometryLibrary.Tests
{
    public class GeometryServiceTests
    {
        private readonly GeometryService _geo = new GeometryService();
        [Fact]
        public void RectangleArea_Works()
        {
            Assert.Equal(20, _geo.RectangleArea(4, 5));
        }
        [Fact]
        public void CircleArea_Works()
        {
            Assert.Equal(Math.PI * 4, _geo.CircleArea(2), 5);
        }
        [Fact]
        public void RectangleArea_NegativeSide_Throws()
        {
            var ex = Assert.Throws<GeometryException>(() => _geo.RectangleArea(-1, 5));
            Assert.Contains("больше нуля", ex.Message);
        }
        [Fact]
        public void CircleArea_ZeroRadius_Throws()
        {
            Assert.Throws<GeometryException>(() => _geo.CircleArea(0));
        }
        [Fact]
        public void TryCatchFinally_ContinuesWorking()
        {
            string log = "";
            try
            {
                _geo.CircleArea(-1);
                log += "не должно выполниться;";
            }
            catch (GeometryException ex)
            {
                log += $"поймано: {ex.Message};";
            }
            finally
            {
                log += "finally выполнен;";
            }
            double result = _geo.RectangleArea(2, 3);
            log += $"площадь после ошибки = {result};";
            Assert.Contains("поймано:", log);
            Assert.Contains("finally выполнен", log);
            Assert.Contains("= 6", log);
        }
    }
}
