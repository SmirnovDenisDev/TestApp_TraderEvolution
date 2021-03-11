
namespace _TestApp_TraderEvolution
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Tool_Pen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Tool_Line = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Tool_Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Tool_Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DrawColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DrawColor_White = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DrawColor_Black = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DrawColor_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DrawColor_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DrawColor_Blu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BackColor_White = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BackColor_Black = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BackColor_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BackColor_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BackColor_Blu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Picture_Rotate90 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Picture_Rotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Draw
            // 
            this.panel_Draw.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Draw.Controls.Add(this.progressBar1);
            this.panel_Draw.Controls.Add(this.pictureBox1);
            this.panel_Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Draw.Location = new System.Drawing.Point(0, 24);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Size = new System.Drawing.Size(800, 426);
            this.panel_Draw.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.ToolStripMenuItem_Picture_Rotate90});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File_New,
            this.ToolStripMenuItem_Open,
            this.ToolStripMenuItem_Save});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // ToolStripMenuItem_File_New
            // 
            this.ToolStripMenuItem_File_New.Name = "ToolStripMenuItem_File_New";
            this.ToolStripMenuItem_File_New.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_File_New.Text = "New picture";
            this.ToolStripMenuItem_File_New.Click += new System.EventHandler(this.ToolStripMenuItem_File_New_Click);
            // 
            // ToolStripMenuItem_Open
            // 
            this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
            this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Open.Text = "Open";
            this.ToolStripMenuItem_Open.Click += new System.EventHandler(this.ToolStripMenuItem_Open_Click);
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Save.Text = "Save";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Tool_Pen,
            this.ToolStripMenuItem_Tool_Line,
            this.ToolStripMenuItem_Tool_Rectangle,
            this.ToolStripMenuItem_Tool_Circle});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // ToolStripMenuItem_Tool_Pen
            // 
            this.ToolStripMenuItem_Tool_Pen.Name = "ToolStripMenuItem_Tool_Pen";
            this.ToolStripMenuItem_Tool_Pen.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Tool_Pen.Text = "Pen";
            this.ToolStripMenuItem_Tool_Pen.Click += new System.EventHandler(this.ToolStripMenuItem_Tool_Choise);
            // 
            // ToolStripMenuItem_Tool_Line
            // 
            this.ToolStripMenuItem_Tool_Line.Name = "ToolStripMenuItem_Tool_Line";
            this.ToolStripMenuItem_Tool_Line.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Tool_Line.Text = "Line";
            this.ToolStripMenuItem_Tool_Line.Click += new System.EventHandler(this.ToolStripMenuItem_Tool_Choise);
            // 
            // ToolStripMenuItem_Tool_Rectangle
            // 
            this.ToolStripMenuItem_Tool_Rectangle.Name = "ToolStripMenuItem_Tool_Rectangle";
            this.ToolStripMenuItem_Tool_Rectangle.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Tool_Rectangle.Text = "Rectangle";
            this.ToolStripMenuItem_Tool_Rectangle.Click += new System.EventHandler(this.ToolStripMenuItem_Tool_Choise);
            // 
            // ToolStripMenuItem_Tool_Circle
            // 
            this.ToolStripMenuItem_Tool_Circle.Name = "ToolStripMenuItem_Tool_Circle";
            this.ToolStripMenuItem_Tool_Circle.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Tool_Circle.Text = "Circle";
            this.ToolStripMenuItem_Tool_Circle.Click += new System.EventHandler(this.ToolStripMenuItem_Tool_Choise);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_DrawColor,
            this.ToolStripMenuItem_BackColor});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // ToolStripMenuItem_DrawColor
            // 
            this.ToolStripMenuItem_DrawColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_DrawColor_White,
            this.ToolStripMenuItem_DrawColor_Black,
            this.ToolStripMenuItem_DrawColor_Red,
            this.ToolStripMenuItem_DrawColor_Green,
            this.ToolStripMenuItem_DrawColor_Blu});
            this.ToolStripMenuItem_DrawColor.Name = "ToolStripMenuItem_DrawColor";
            this.ToolStripMenuItem_DrawColor.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_DrawColor.Text = "Draw Color";
            // 
            // ToolStripMenuItem_DrawColor_White
            // 
            this.ToolStripMenuItem_DrawColor_White.Name = "ToolStripMenuItem_DrawColor_White";
            this.ToolStripMenuItem_DrawColor_White.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_DrawColor_White.Text = " ";
            this.ToolStripMenuItem_DrawColor_White.Click += new System.EventHandler(this.SetDrawColor);
            // 
            // ToolStripMenuItem_DrawColor_Black
            // 
            this.ToolStripMenuItem_DrawColor_Black.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem_DrawColor_Black.Name = "ToolStripMenuItem_DrawColor_Black";
            this.ToolStripMenuItem_DrawColor_Black.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_DrawColor_Black.Text = " ";
            this.ToolStripMenuItem_DrawColor_Black.Click += new System.EventHandler(this.SetDrawColor);
            // 
            // ToolStripMenuItem_DrawColor_Red
            // 
            this.ToolStripMenuItem_DrawColor_Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItem_DrawColor_Red.Name = "ToolStripMenuItem_DrawColor_Red";
            this.ToolStripMenuItem_DrawColor_Red.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_DrawColor_Red.Text = " ";
            this.ToolStripMenuItem_DrawColor_Red.Click += new System.EventHandler(this.SetDrawColor);
            // 
            // ToolStripMenuItem_DrawColor_Green
            // 
            this.ToolStripMenuItem_DrawColor_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItem_DrawColor_Green.Name = "ToolStripMenuItem_DrawColor_Green";
            this.ToolStripMenuItem_DrawColor_Green.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_DrawColor_Green.Text = " ";
            this.ToolStripMenuItem_DrawColor_Green.Click += new System.EventHandler(this.SetDrawColor);
            // 
            // ToolStripMenuItem_DrawColor_Blu
            // 
            this.ToolStripMenuItem_DrawColor_Blu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ToolStripMenuItem_DrawColor_Blu.Name = "ToolStripMenuItem_DrawColor_Blu";
            this.ToolStripMenuItem_DrawColor_Blu.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_DrawColor_Blu.Text = " ";
            this.ToolStripMenuItem_DrawColor_Blu.Click += new System.EventHandler(this.SetDrawColor);
            // 
            // ToolStripMenuItem_BackColor
            // 
            this.ToolStripMenuItem_BackColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_BackColor_White,
            this.ToolStripMenuItem_BackColor_Black,
            this.ToolStripMenuItem_BackColor_Red,
            this.ToolStripMenuItem_BackColor_Green,
            this.ToolStripMenuItem_BackColor_Blu});
            this.ToolStripMenuItem_BackColor.Name = "ToolStripMenuItem_BackColor";
            this.ToolStripMenuItem_BackColor.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_BackColor.Text = "Background Color";
            // 
            // ToolStripMenuItem_BackColor_White
            // 
            this.ToolStripMenuItem_BackColor_White.Name = "ToolStripMenuItem_BackColor_White";
            this.ToolStripMenuItem_BackColor_White.Size = new System.Drawing.Size(77, 22);
            this.ToolStripMenuItem_BackColor_White.Text = " ";
            this.ToolStripMenuItem_BackColor_White.Click += new System.EventHandler(this.SetBackColor);
            // 
            // ToolStripMenuItem_BackColor_Black
            // 
            this.ToolStripMenuItem_BackColor_Black.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem_BackColor_Black.Name = "ToolStripMenuItem_BackColor_Black";
            this.ToolStripMenuItem_BackColor_Black.Size = new System.Drawing.Size(77, 22);
            this.ToolStripMenuItem_BackColor_Black.Text = " ";
            this.ToolStripMenuItem_BackColor_Black.Click += new System.EventHandler(this.SetBackColor);
            // 
            // ToolStripMenuItem_BackColor_Red
            // 
            this.ToolStripMenuItem_BackColor_Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItem_BackColor_Red.Name = "ToolStripMenuItem_BackColor_Red";
            this.ToolStripMenuItem_BackColor_Red.Size = new System.Drawing.Size(77, 22);
            this.ToolStripMenuItem_BackColor_Red.Text = " ";
            this.ToolStripMenuItem_BackColor_Red.Click += new System.EventHandler(this.SetBackColor);
            // 
            // ToolStripMenuItem_BackColor_Green
            // 
            this.ToolStripMenuItem_BackColor_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItem_BackColor_Green.Name = "ToolStripMenuItem_BackColor_Green";
            this.ToolStripMenuItem_BackColor_Green.Size = new System.Drawing.Size(77, 22);
            this.ToolStripMenuItem_BackColor_Green.Text = " ";
            this.ToolStripMenuItem_BackColor_Green.Click += new System.EventHandler(this.SetBackColor);
            // 
            // ToolStripMenuItem_BackColor_Blu
            // 
            this.ToolStripMenuItem_BackColor_Blu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ToolStripMenuItem_BackColor_Blu.Name = "ToolStripMenuItem_BackColor_Blu";
            this.ToolStripMenuItem_BackColor_Blu.Size = new System.Drawing.Size(77, 22);
            this.ToolStripMenuItem_BackColor_Blu.Text = " ";
            this.ToolStripMenuItem_BackColor_Blu.Click += new System.EventHandler(this.SetBackColor);
            // 
            // ToolStripMenuItem_Picture_Rotate90
            // 
            this.ToolStripMenuItem_Picture_Rotate90.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotate90ToolStripMenuItem,
            this.ToolStripMenuItem_Picture_Rotate180});
            this.ToolStripMenuItem_Picture_Rotate90.Name = "ToolStripMenuItem_Picture_Rotate90";
            this.ToolStripMenuItem_Picture_Rotate90.Size = new System.Drawing.Size(56, 20);
            this.ToolStripMenuItem_Picture_Rotate90.Text = "Picture";
            // 
            // ToolStripMenuItem_Picture_Rotate180
            // 
            this.ToolStripMenuItem_Picture_Rotate180.Name = "ToolStripMenuItem_Picture_Rotate180";
            this.ToolStripMenuItem_Picture_Rotate180.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Picture_Rotate180.Text = "Rotate 180";
            this.ToolStripMenuItem_Picture_Rotate180.Click += new System.EventHandler(this.ToolStripMenuItem_Picture_Rotate180_Click);
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotate90ToolStripMenuItem.Text = "Rotate 90";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.rotate90ToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(239, 391);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Draw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Simple Paint";
            this.panel_Draw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tool_Pen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tool_Line;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tool_Rectangle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tool_Circle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_New;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DrawColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DrawColor_Black;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DrawColor_Red;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BackColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DrawColor_Green;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DrawColor_Blu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BackColor_White;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BackColor_Black;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BackColor_Red;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BackColor_Green;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BackColor_Blu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DrawColor_White;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Picture_Rotate90;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Picture_Rotate180;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

