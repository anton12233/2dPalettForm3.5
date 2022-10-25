using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2dPalettForm_3._5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Point> points = new List<Point>();

        private void PalettPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = new Point(e.X, e.Y);
            points.Add(clickPoint);
            var g = this.PalettPanel.CreateGraphics();
            Draw(g);
        }

        private void Draw(Graphics g)
        {

            g.Clear(Color.Gray);

            PointCount();
            CalcSquare();
            Font font = new Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Pixel);

            for (int i = 0; i < points.Count - 1; i++)
            {
                g.FillEllipse(Brushes.Black, points[i].X - 4, points[i].Y - 4, 8, 8);
                g.DrawLine(Pens.Red, points[i], points[i + 1]);
                if (i == 0)
                    g.DrawString($"[{points[i].X}, {points[i].Y}] (FP)", font, Brushes.Black, points[i].X + 5, points[i].Y + 5);
                else
                    g.DrawString($"[{points[i].X}, {points[i].Y}]", font, Brushes.Black, points[i].X + 5, points[i].Y + 5);

            }

            g.FillEllipse(Brushes.Black, points[points.Count - 1].X - 4, points[points.Count - 1].Y - 4, 8, 8);
            g.DrawLine(Pens.Red, points[points.Count - 1], points[0]);
            g.DrawString($"[{points[points.Count - 1].X}, {points[points.Count - 1].Y}] (LP)", font, Brushes.Black, points[points.Count - 1].X + 5, points[points.Count - 1].Y + 5);

        }

        private void PointCount()
        {
            this.TotalPoint.Text = $"Total points: {points.Count}";
        }

        private void CalcSquare()
        {
            float total = 0;

            if (points.Count > 1)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    total += points[i].X * points[i + 1].Y;
                    total -= points[i].Y * points[i + 1].X;
                }
                total += points[points.Count - 1].X * points[0].Y;
                total -= points[points.Count - 1].Y * points[0].X;

                total = Math.Abs(total / 2);
            }
            this.Square.Text = $"S: {total}";

        }

        private void Clear()
        {
            points = new List<Point>();
            var g = this.PalettPanel.CreateGraphics();
            g.Clear(Color.Gray);
            PointCount();
            CalcSquare();
        }

        private void DeleteFirst_Click(object sender, EventArgs e)
        {
            var g = this.PalettPanel.CreateGraphics();

            if (points.Count > 1)
            {
                points.RemoveAt(0);
                Draw(g);
            }
            else if (points.Count == 1)
            {
                Clear();
            }
        }

        private void DeleteLast_Click(object sender, EventArgs e)
        {
            var g = this.PalettPanel.CreateGraphics();

            if (points.Count > 1)
            {
                points.RemoveAt(points.Count - 1);
                Draw(g);
            }
            else if (points.Count == 1)
            {
                Clear();
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
