
using System;
using System.Collections.Generic;

namespace Hexagon
{
    class Model
    {
        private DrawingPoint _center;
        private List<DrawingPoint> _hexagons;
        private int _mapSize;
        public const int _radius = 15;

        public Model(int width, int height, int size)
        {
            _center = new DrawingPoint(width / 2, height / 2);
            _hexagons = new List<DrawingPoint>();
            _mapSize = size;

            ProduceMap(_mapSize);
        }

        #region Properties
        public int Radius
        {
            get
            {
                return _radius;
            }
        }
        #endregion

        public List<DrawingPoint> GetHexagons()
        {
            return _hexagons;
        }

        public void SetWidthAndHeight(int w, int h)
        {
            _center = new DrawingPoint(w / 2, h / 2);
            _hexagons.Clear();
            ProduceMap(_mapSize);
        }

        private void ProduceMap(int size)
        {
            _hexagons.Add(_center);

            List<DrawingPoint> outSider, newHexagons;
            newHexagons = new List<DrawingPoint>();
            double[] cos = new double[6];
            double[] sin = new double[6];
            for (int i = 0; i < 6; i++)
            {
                cos[i] = Math.Cos(60 * Math.PI * i / 180);
                sin[i] = Math.Sin(60 * Math.PI * i / 180);
            }
            DrawingPoint[] points = new DrawingPoint[7];
            double r = _radius * sin[1];
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    points[j] =
                        new DrawingPoint(
                            2 * r * i * cos[j],
                            2 * r * i * sin[j]
                        ) + _center;
                    _hexagons.Add(points[j]);
                }
                points[6] = points[0];
                for (int j = 0; j < 6; j++)
                {
                    for (int a = 1; a < i; a++)
                    {
                        DrawingPoint temp = a * points[j] / i + (i - a) * points[j + 1] / i;
                        _hexagons.Add(temp);
                    }
                }
            }

            ProducePrivateRegion(_mapSize-1);
        }

        private void ProducePrivateRegion(int size)
        {
            for (int i = 0; i < 6; i++)
            {
                
            }
        }
    }
}
