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
    
     partial class Form1
    {
        private int PicWid, PicHeight, Form1Wid, Form1Height;
        private double Ratio_Width, Ratio_Height;
        private void Autosize()
        {
            pictureBox1.Width = Convert.ToInt32(ClientSize.Width / Ratio_Width);
            pictureBox1.Height = Convert.ToInt32(ClientSize.Height / Ratio_Height);
        }
    }
}
