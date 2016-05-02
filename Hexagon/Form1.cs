using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hexagon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PaintBoard(object sender, PaintEventArgs e)
        {
            DrawingPoint center = new DrawingPoint(doubleBufferedPanel_Board.Width / 2, doubleBufferedPanel_Board.Height/2);
            int radius = 50;
            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double rad = (30 + i * 60) * Math.PI / 180;
                points[i] = new Point((int)(center.GetX() + radius * Math.Cos(rad)), (int)(center.GetY() + radius * Math.Sin(rad)));
            }
            Pen pen = new Pen(Color.Aqua, 4);
            e.Graphics.DrawPolygon(pen, points);
            e.Graphics.DrawLine(pen, new Point(0, 0), new Point((int)center.GetX(), (int)center.GetY()));
        }

        private void doubleBufferedPanel_Board_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate(true);
        }
    }
}
