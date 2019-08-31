//Form1.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinatedPic
{
    public partial class Form1 : Form
    {
            //Author:张凯翔
            //copyright 2019
            //allrightsreserved

        public Form1()
        {
            InitializeComponent();
        }
        private int x, y,x1,y1;//初始化鼠标坐标值
        private bool Drawable=false;
        private int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        private int ScreenHeight=Screen.PrimaryScreen.Bounds.Height;//获取屏幕分辨率
        private Graphics g;
        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            XCoordination.SetBounds(pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Size.Height + 2, pictureBox1.Width, 45);
            YCoordination.SetBounds(pictureBox1.Location.X - 2 - 45, pictureBox1.Location.Y, 45, pictureBox1.Height);
            XCoordination.Maximum = XCoordination.Width;
            YCoordination.Maximum = YCoordination.Height;
        }//设置UI自适应缩放
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drawable == false)
            {
                x = e.X; y = pictureBox1.Height - e.Y;

                MouseOverCoordination.Text = x + "," + y;
                return;
            }
            x1 = e.X;
            y1 = pictureBox1.Height - e.Y;
            g = pictureBox1.CreateGraphics();
            MouseOverCoordination.Text = x + "," + y;
            MouseClickedCoordinationX.Text = Convert.ToString(x); MouseClickedCoordinationY.Text = Convert.ToString(y);
            g.DrawLine(new Pen(Color.Black), x,pictureBox1.Height - y, x1, pictureBox1.Height - y1);
            x = e.X;y = pictureBox1.Height-e.Y;
            MouseOverCoordination.Text = x1 + "," + y1;
            MouseClickedCoordinationX.Text = Convert.ToString(x1);
            MouseClickedCoordinationY.Text = Convert.ToString(y1);
        }//划线
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drawable = true;
            x = e.X;
            y = pictureBox1.Height - e.Y;
            ClearPenwrote();
        }//鼠标按下动作
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Drawable = false;
        }//鼠标松开动作
        private void YCoordination_ValueChanged(object sender, EventArgs e)
        {
            y1 = YCoordination.Value;
            MouseClickedCoordinationY.Text = Convert.ToString(y1);
            MouseOverCoordination.Text = x + "," + y;
            
            DrawPoint();
        }//Y坐标轴value改变
        private void XCoordination_ValueChanged(object sender, EventArgs e)
        {
            x1 = XCoordination.Value;
            MouseClickedCoordinationX.Text = Convert.ToString(x1);
            MouseOverCoordination.Text = x + "," + y;

            DrawPoint();
        }//X坐标轴value改变
        private void ClearPenwrote()
        {
            if (IfClear.Checked)
            {
                try
                {
                    pictureBox1.BackgroundImage = Image.FromFile(@openFileDialog1.FileName);
                }
                catch
                {
                    try
                    {
                        g.Clear(Color.White);
                        return;
                    }
                    catch { return; }
                }
            }
        }//擦除画笔
        private void button1_Click(object sender, EventArgs e)
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog1.InitialDirectory = dir;
            openFileDialog1.ShowDialog();
        }//选取文件
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image SelectedPic = Image.FromFile(@openFileDialog1.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Width = SelectedPic.Width;
            pictureBox1.Height = SelectedPic.Height;
            pictureBox1.BackgroundImage = SelectedPic;
        }//选取完毕
        private void Locate_Click(object sender, EventArgs e)
        {
            ClearPenwrote();
            try
            {
                Convert.ToInt32(MouseClickedCoordinationX.Text);
                Convert.ToInt32(MouseClickedCoordinationY.Text);
            }
            catch
            {
                MouseClickedCoordinationX.Text = string.Empty;
                MouseClickedCoordinationY.Text = string.Empty;
                return;
            }
            if (MouseClickedCoordinationX.Text == string.Empty || MouseClickedCoordinationY.Text == string.Empty)
                return;
            y = Convert.ToInt32(MouseClickedCoordinationY.Text);
            x = Convert.ToInt32(MouseClickedCoordinationX.Text);
            MouseClickedCoordinationY.Text = Convert.ToString(y);
            MouseClickedCoordinationX.Text = Convert.ToString(x);
            DrawPoint();
        }//手动输入坐标描点
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseClickedCoordinationX.Text = Convert.ToString(x);
            MouseClickedCoordinationY.Text = Convert.ToString(y);
            //textBox显示鼠标点的坐标
            x1 = x;y1 = y;
            XCoordination.Value = x1;
            YCoordination.Value = y1;//坐标轴改变value
            DrawPoint();//描点     
        }//图上描点
        private void DrawPoint()
        {
            g = pictureBox1.CreateGraphics();
            g.FillEllipse(Brushes.Black, x1, pictureBox1.Height - y1, 2, 2);
        }//描点函数
    }
}
