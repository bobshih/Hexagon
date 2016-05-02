
using System;
namespace Hexagon
{
    class vector2
    {
        double _x, _y;

        public vector2(double x, double y)
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

        static public vector2 operator +(vector2 left, vector2 right)
        {
            return new vector2(left.X + right.X, left.Y + right.Y);
        }

        static public vector2 operator -(vector2 left, vector2 right)
        {
            return new vector2(left.X - right.X, left.Y - right.Y);
        }

        static public vector2 operator *(vector2 left, double right)
        {
            return new vector2(left.X * right, left.Y * right);
        }

        static public vector2 operator *(double left, vector2 right)
        {
            return new vector2(right.X * left, right.Y * left);
        }

        static public vector2 operator /(vector2 left, double right)
        {
            return new vector2(left.X / right, left.Y / right);
        }

        public double length()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }
    }
}
