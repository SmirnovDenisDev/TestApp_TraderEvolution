using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TestApp_TraderEvolution.Draw_Class
{
    class ToolRectangle : IDraw
    {
        public FormMain Form { get; set; }
        public Point PointStart { get; set; }
        public Point PointEnd { get; set; }

        public ToolRectangle(FormMain form)
        {
            Form = form;
        }

        public void UnsubscribeHandler()
        {
            Form.MyPictureBox.MouseDown -= SetStartPoint;
            Form.MyPictureBox.MouseUp -= SetEndPoint;
        }
        public void SubscribeHandler()
        {
            Form.MyPictureBox.MouseDown += SetStartPoint;
            Form.MyPictureBox.MouseUp += SetEndPoint;
        }

        public void Drawing(Point pointStart, Point pointEnd)
        {
            Brush brush = new SolidBrush(Form.BackColor);

            Graphics graphics;
            graphics = Graphics.FromImage(Form.Picture);
            int x = Math.Min(pointStart.X, pointEnd.X);
            int y = Math.Min(pointStart.Y, pointEnd.Y);
            int w = Math.Abs(pointEnd.X - pointStart.X);
            int h = Math.Abs(pointEnd.Y - pointStart.Y);
            Rectangle mRect = new Rectangle(x, y, w, h);

            graphics.DrawRectangle(Form.MyPen, mRect);
            graphics.FillRectangle(brush, mRect);
            Form.MyPictureBox.Image = Form.Picture;
        }

        public void SetStartPoint(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointStart = new Point(e.X, e.Y);
            }
        }

        public void SetEndPoint(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointEnd = new Point(e.X, e.Y);
                Drawing(PointStart, PointEnd);
            }
        }
    }
}
