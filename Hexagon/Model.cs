
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hexagon
{
    class Model
    {
        private vector2 _center;
        private List<vector2> _hexagons;
        private int _mapSize;
        public const int _radius = 10;

        public Model(int width, int height, int size)
        {
            _center = new vector2(width / 2, height / 2);
            _hexagons = new List<vector2>();
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

        public List<vector2> GetHexagons()
        {
            return _hexagons;
        }

        public void SetWidthAndHeight(int w, int h)
        {
            _center = new vector2(w / 2, h / 2);
            _hexagons.Clear();
            ProduceMap(_mapSize);
        }

        private void ProduceMap(int size)
        {
            _hexagons.Add(_center);

            List<vector2> outSider, newHexagons;
            newHexagons = new List<vector2>();
            double[] cos = new double[6];
            double[] sin = new double[6];
            for (int i = 0; i < 6; i++)
            {
                cos[i] = Math.Cos(60 * Math.PI * i / 180);
                sin[i] = Math.Sin(60 * Math.PI * i / 180);
            }
            vector2[] points = new vector2[7];
            double r = _radius * sin[1];
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    points[j] =
                        new vector2(
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
                        vector2 temp = a * points[j] / i + (i - a) * points[j + 1] / i;
                        _hexagons.Add(temp);
                    }
                }
            }

            ProducePrivateRegion(2 * _mapSize - 1, r);
        }

        private void ProducePrivateRegion(int size, double r)
        {
            double[] cos = new double[6];
            double[] sin = new double[6];
            for (int i = 0; i < 6; i++)
            {
                cos[i] = Math.Cos(60 * Math.PI * i / 180);
                sin[i] = Math.Sin(60 * Math.PI * i / 180);
            }
            for (int i = 0; i < 6; i++)
            {
                int rad = 3 * _radius * _mapSize;
                vector2 end = new vector2(
                    rad * sin[i],
                    rad * cos[i]
                ) + _center;
                List<vector2> list = ProducePersonalRegion(_center - end, _mapSize - 1, 0);
                _hexagons.AddRange(list.Select((x) => x * 2 * _radius + end));
                _hexagons.Add(end);
            }
        }

        private List<vector2> ProducePersonalRegion(vector2 v, int n, int d)
        {
            List<vector2> list = new List<vector2>();
            double r = Math.Cos(30 * Math.PI / 180);
            vector2 right = new vector2(
                v.X * Math.Cos(30 * Math.PI / 180) - v.Y * Math.Sin(30 * Math.PI / 180),
                v.X * Math.Sin(30 * Math.PI / 180) + v.Y * Math.Cos(30 * Math.PI / 180)
            );
            right = right / right.length() * r;
            vector2 left = new vector2(
                v.X * Math.Cos(-30 * Math.PI / 180) - v.Y * Math.Sin(-30 * Math.PI / 180),
                v.X * Math.Sin(-30 * Math.PI / 180) + v.Y * Math.Cos(-30 * Math.PI / 180)
            );

            left = left / left.length() * r;

            for (int i = d; i <= n; i++)
            {
                vector2 v1 = left * (i);
                vector2 v2 = right * (i);
                for (int j = 0; j <= i; j++)
                {
                    vector2 temp = (j * v1 + (i - j) * v2) / i;
                    list.Add(temp);
                }
            }
            return list;
        }
    }
}
