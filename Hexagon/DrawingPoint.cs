
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

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        static public DrawingPoint operator +(DrawingPoint left,DrawingPoint right)
        {
            return new DrawingPoint(left.X + right.X, left.Y + right.Y);
        }

        static public DrawingPoint operator *(DrawingPoint left, double right)
        {
            return new DrawingPoint(left.X * right, left.Y * right);
        }

        static public DrawingPoint operator *(double left, DrawingPoint right)
        {
            return new DrawingPoint(right.X * left, right.Y * left);
        }

        static public DrawingPoint operator /(DrawingPoint left, double right)
        {
            return new DrawingPoint(left.X / right, left.Y / right);
        }
    }
}
