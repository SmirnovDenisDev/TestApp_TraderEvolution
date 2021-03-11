using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TestApp_TraderEvolution
{
    interface IDraw
    {
        FormMain Form { get; set; }
        Point PointStart { get; set; }
        Point PointEnd { get; set; }
        void Drawing(Point pointStart, Point pointEnd);
        void SetStartPoint(object sender, MouseEventArgs e);
        void SetEndPoint(object sender, MouseEventArgs e);
        void UnsubscribeHandler();
        void SubscribeHandler();
    }
}
