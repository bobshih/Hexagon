
namespace Hexagon
{
    class DrawingPoint
    {
        double _x, _y;

        public DrawingPoint(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetX()
        {
            return _x;
        }

        public double GetY()
        {
            return _y;
        }
    }
}
