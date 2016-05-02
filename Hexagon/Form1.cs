using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hexagon
{
    public partial class Form1 : Form
    {
        private PresentionModel _presentionModel;

        public Form1()
        {
            InitializeComponent();
            _presentionModel = new PresentionModel(doubleBufferedPanel_Board.Width, doubleBufferedPanel_Board.Height);
        }

        private void PaintBoard(object sender, PaintEventArgs e)
        {
            vector2 center = new vector2(doubleBufferedPanel_Board.Width / 2, doubleBufferedPanel_Board.Height/2);
            int radius = _presentionModel.Radius;
            Pen pen = new Pen(Color.Aqua, 2);
            Point[] points = new Point[6];

            foreach (vector2 dp in _presentionModel.GetHexagons())
            {
                for (int i = 0; i < 6; i++)
                {
                    double rad = (30 + i * 60) * Math.PI / 180;
                    points[i] = new Point((int)(dp.X + radius * Math.Cos(rad)), (int)(dp.Y + radius * Math.Sin(rad)));
                }
                e.Graphics.DrawPolygon(pen, points);
            }
            
            
            // e.Graphics.DrawLine(pen, new Point(0, 0), new Point((int)center.GetX(), (int)center.GetY()));
        }

        private void doubleBufferedPanel_Board_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            _presentionModel.SetWidthAndHeight(doubleBufferedPanel_Board.Width, doubleBufferedPanel_Board.Height);
            Invalidate(true);
        }
    }
}
