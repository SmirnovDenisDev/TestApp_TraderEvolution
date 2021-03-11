using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _TestApp_TraderEvolution.Draw_Class;

namespace _TestApp_TraderEvolution
{
    public partial class FormMain : Form
    {
        int index = 0;
        public Bitmap Picture { get; set; }
        public Color DrawColor { get; set; }
        public Color BackColor { get; set; }
        public Pen MyPen { get; set; }
        public PictureBox MyPictureBox { get; set; }

        List<IDraw> tooList = new List<IDraw>();
        public FormMain()
        {
            InitializeComponent();
            Picture = new Bitmap(pictureBox1.Size.Width , pictureBox1.Size.Height);
            DrawColor = Color.Black;
            BackColor = Color.White;
            MyPictureBox = this.pictureBox1;
            MyPen = new Pen(DrawColor);

            tooList.Add(new ToolPen(this));
            tooList.Add(new ToolLine(this));
            tooList.Add(new ToolRectangle(this));
            tooList.Add(new ToolCircle(this));
        }

        private void SetDrawColor(object sender, EventArgs e)
        {
            ToolStripMenuItem menuDrawColor = (ToolStripMenuItem)sender;
            DrawColor = menuDrawColor.BackColor;
            MyPen = new Pen(DrawColor);
        }

        private void SetBackColor(object sender, EventArgs e)
        {
            ToolStripMenuItem menuBackColor = (ToolStripMenuItem)sender;
            BackColor = menuBackColor.BackColor;
        }
       
        private void ToolStripMenuItem_Tool_Choise(object sender, EventArgs e)
        {
            ToolStripMenuItem choiseTool = (ToolStripMenuItem)sender;
            
            switch (choiseTool.Name)
            {
                case "ToolStripMenuItem_Tool_Pen":
                    tooList[index].UnsubscribeHandler();
                    index = 0;
                    break;

                case "ToolStripMenuItem_Tool_Line":
                    tooList[index].UnsubscribeHandler();
                    index = 1;
                    break;

                case "ToolStripMenuItem_Tool_Rectangle":
                    tooList[index].UnsubscribeHandler();
                    index = 2;
                    break;

                case "ToolStripMenuItem_Tool_Circle":
                    tooList[index].UnsubscribeHandler();
                    index = 3;
                    break;

                default:
                    break;
            }
            tooList[index].SubscribeHandler();
        }

        private void ToolStripMenuItem_File_New_Click(object sender, EventArgs e)
        {
            Picture = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            MyPictureBox.Image = Picture;
        }

        private void ToolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "*.jpg";
            openFile.Filter = "(*.jpg)|*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFile.FileName;
                Picture = new Bitmap(fullPath);
                MyPictureBox.Image = Picture;
            }
        }

        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.jpg";
            saveFile.Filter = "(*.jpg)|*.jpg";
            
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                MyPictureBox.Image.Save(saveFile.FileName);
            }
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true;
            Thread myThread = new Thread(new ThreadStart(ImageRotate90));
            myThread.IsBackground = true;
            myThread.Start();
            for (int i = 0; i < 100; i++)
            {
                this.progressBar1.Value = i;
                Thread.Sleep(100);
            }
            this.progressBar1.Visible = false;
        }

        private void ImageRotate90()
        {
            Picture.RotateFlip(RotateFlipType.Rotate90FlipY);
            MyPictureBox.Image = Picture;
        }

        private void ToolStripMenuItem_Picture_Rotate180_Click(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true;
            Thread myThread = new Thread(new ThreadStart(ImageRotate180));
            myThread.IsBackground = true;
            myThread.Start();
            for (int i = 0; i < 100; i++)
            {
                this.progressBar1.Value = i;
                Thread.Sleep(100);
            }
            this.progressBar1.Visible = false;
        }

        private void ImageRotate180()
        {
            Picture.RotateFlip(RotateFlipType.Rotate180FlipY);
            MyPictureBox.Image = Picture;
        }
    }
}
