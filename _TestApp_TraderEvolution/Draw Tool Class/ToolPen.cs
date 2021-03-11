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
    public class ToolPen : IDraw
    {
        EventHandler handlerUp = null;
        public FormMain Form { get; set; }
        public Point PointStart { get; set; }
        public Point PointEnd { get; set; }

        int xStart = 0;
        int yStart = 0;

        public ToolPen(FormMain form)
        {
            Form = form;
        }

        public void UnsubscribeHandler()
        {
            Form.MyPictureBox.MouseMove -= SetStartPoint;
            Form.MyPictureBox.MouseUp -= SetEndPoint;
        }
        public void SubscribeHandler()
        {
            Form.MyPictureBox.MouseMove += SetStartPoint;
            Form.MyPictureBox.MouseUp += SetEndPoint;
        }
        public void Drawing(Point pointStart, Point pointEnd)
        {
            Graphics graphics;
            graphics = Graphics.FromImage(Form.Picture);

            graphics.DrawLine(Form.MyPen, xStart, yStart, pointStart.X, pointStart.Y);
            Form.MyPictureBox.Image = Form.Picture;
        }

        public void SetStartPoint(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                PointStart = new Point(e.X, e.Y);
                Drawing(PointStart, PointEnd);
            }
            xStart = e.X;
            yStart = e.Y;
        }

        public void SetEndPoint(object sender, MouseEventArgs e)
        {
            /*
            if (e.Button == MouseButtons.Left)
            {
                PointEnd = new Point(e.X, e.Y);
                Drawing(PointStart, PointEnd);
            }
            */
        }
    }
}
