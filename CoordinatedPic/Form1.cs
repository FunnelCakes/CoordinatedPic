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
            //更新日志：新增折线功能，更加方便实用；另增加Z坐标及钻头速度的GUI，后续需给定SDK才可完成。

        public Form1()
        {
            InitializeComponent();
        }
        private string selection;
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
        private int movingX, movingY;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selection == null)
            {
                MouseOverCoordination.Text = e.X + "," + (pictureBox1.Height - e.Y);
                movingX = e.X;movingY = pictureBox1.Height - e.Y;
                return;
            }
            if (selection == "Free Curve")
            {
                this.Cursor = Cursors.Default;
                if (Drawable == false)
                {
                    MouseOverCoordination.Text = e.X.ToString()+","+((pictureBox1.Height-e.Y).ToString());
                    return;
                }
                x1 = e.X;
                y1 = pictureBox1.Height - e.Y;
                g = pictureBox1.CreateGraphics();
                MouseOverCoordination.Text = x + "," + y;
                MouseClickedCoordinationX.Text = Convert.ToString(x); MouseClickedCoordinationY.Text = Convert.ToString(y);
                g.DrawLine(new Pen(Color.Black), x, pictureBox1.Height - y, x1, pictureBox1.Height - y1);
                x = e.X; y = pictureBox1.Height - e.Y;
                MouseOverCoordination.Text = x1 + "," + y1;
                MouseClickedCoordinationX.Text = Convert.ToString(x1);
                MouseClickedCoordinationY.Text = Convert.ToString(y1);
            }
            if(selection=="Polyline")
            {
                this.Cursor = Cursors.Cross;
                MouseOverCoordination.Text = e.X.ToString()  + "," + (pictureBox1.Height - e.Y).ToString();
            }
        }//划线&鼠标滑过
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (selection == null) { return; }
            if (selection != string.Empty)
            {
                Drawable = true;
                x = e.X;
                y = pictureBox1.Height - e.Y;
                ClearPenwrote();
                MouseClickedCoordinationX.Text = x.ToString();
                MouseClickedCoordinationY.Text = y.ToString();
            }
        }//鼠标按下动作
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selection == null) { return;}
            if (selection !=null)
            { Drawable = false; }
        }//鼠标松开动作
        private void YCoordination_ValueChanged(object sender, EventArgs e)
        {
            y = YCoordination.Value;
            MouseClickedCoordinationY.Text = Convert.ToString(y);
            MouseOverCoordination.Text = x + "," + y;  
        }//Y坐标轴value改变
        private void XCoordination_ValueChanged(object sender, EventArgs e)
        {
            x = XCoordination.Value;
            MouseClickedCoordinationX.Text = Convert.ToString(x);
            MouseOverCoordination.Text = x + "," + y;

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
        private bool Clicked;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearPenwrote();
            if (selection == "Polyline")
            {
                g = pictureBox1.CreateGraphics();
                if (Clicked == false)
                {
                    g.FillEllipse(new SolidBrush(Color.Black),x,pictureBox1.Height-y,2,2);
                    x1 = x;y1 = y;
                    Clicked = true;
                    XCoordination.Value = x;
                    YCoordination.Value = y;
                }
                if (Clicked == true)
                {
                    g.FillEllipse(new SolidBrush(Color.Black), x, pictureBox1.Height-y, 2, 2);
                    g.DrawLine(new Pen(Color.Black), x,pictureBox1.Height-y, x1,pictureBox1.Height-y1);
                    x1 = x;y1 = y;
                    XCoordination.Value = x;
                    YCoordination.Value = y;
                }
            }
            if (selection == "Free Curve")
            {
                DrawPoint(x, y);
                XCoordination.Value = x;
                YCoordination.Value = y;
            }
            if(selection==null)
            {
                DrawPoint(movingX, movingY);
                XCoordination.Value = movingX;
                YCoordination.Value = movingY;
            }
        }//画折线
        private void Polyline_CheckedChanged(object sender, EventArgs e)
        {
            if ((!FreeCurve.Checked) & (!(Polyline.Checked))) { return; }
            if (FreeCurve.Checked & (!(Polyline.Checked))) { selection = "Free Curve"; }
            if ((!FreeCurve.Checked) & Polyline.Checked) { selection = "Polyline"; }
            Clicked = false;
        }
        private void FreeCurve_CheckedChanged(object sender, EventArgs e)
        {
            if ((!FreeCurve.Checked) & (!(Polyline.Checked))) { return; }
            if (FreeCurve.Checked &(!( Polyline.Checked))) { selection = "Free Curve"; }
            if ((!FreeCurve.Checked) & Polyline.Checked) { selection = "Polyline"; }
            Clicked = false;
        }//radiobutton的选择
        /*private int PicWid, PicHeight, Form1Wid, Form1Heitht;
private double Ratio_Width, Ratio_Height;*/
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
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
            if (Clicked== false)
            {
                DrawPoint(x, y);
                x1 = x;y1 = y;
                if (selection == "Polyline") { Clicked = true; }
                YCoordination.Value = y;
                XCoordination.Value = x;
            }
            if (Clicked == true)
            {
                DrawPoint(x, y);
                g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(Color.Black), x1, pictureBox1.Height - y1, x, pictureBox1.Height - y);
                x1 = x;y1 = y;
                Clicked = true;
                XCoordination.Value = x;
                YCoordination.Value = y;
            }
        }//手动输入坐标描点
        private void DrawPoint(int x,int y)
        {
            g = pictureBox1.CreateGraphics();
            g.FillEllipse(Brushes.Black, x, pictureBox1.Height - y, 2, 2);
        }//描点函数
        
        #region SDK_Related
        private void ZCoordination_ValueChanged(object sender, EventArgs e)
        {
            ZValue.Text = ZCoordination.Value.ToString();
        }//Z坐标value改变

        private void ZvalueOK_Click(object sender, EventArgs e)
        {
            try
            {
                ZCoordination.Value = Convert.ToInt32(ZValue.Text);
            }
            catch 
            {
                return;
            }
        }//手动设置Z值

        private void ZmaxOK_Click(object sender, EventArgs e)
        {
            try
            {
                ZCoordination.Maximum = Convert.ToInt32(Zmax.Text);
            }
            catch
            { 
                return;
            }
        }//设置Z最大值}
        #endregion////


    }
}
