namespace CoordinatedPic
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseClickedCoordinationX = new System.Windows.Forms.TextBox();
            this.Locate = new System.Windows.Forms.Button();
            this.XCoordination = new System.Windows.Forms.TrackBar();
            this.YCoordination = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MouseOverCoordination = new System.Windows.Forms.Label();
            this.IfClear = new System.Windows.Forms.CheckBox();
            this.MouseClickedCoordinationY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FreeCurve = new System.Windows.Forms.RadioButton();
            this.Polyline = new System.Windows.Forms.RadioButton();
            this.ZCoordination = new System.Windows.Forms.TrackBar();
            this.ZValue = new System.Windows.Forms.TextBox();
            this.ZvalueOK = new System.Windows.Forms.Button();
            this.Zmax = new System.Windows.Forms.TextBox();
            this.ZmaxOK = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.TextBox();
            this.SpeedOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XCoordination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCoordination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZCoordination)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(51, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 243);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // MouseClickedCoordinationX
            // 
            this.MouseClickedCoordinationX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MouseClickedCoordinationX.Location = new System.Drawing.Point(56, 316);
            this.MouseClickedCoordinationX.Name = "MouseClickedCoordinationX";
            this.MouseClickedCoordinationX.Size = new System.Drawing.Size(29, 21);
            this.MouseClickedCoordinationX.TabIndex = 1;
            // 
            // Locate
            // 
            this.Locate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Locate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Locate.Location = new System.Drawing.Point(162, 316);
            this.Locate.Name = "Locate";
            this.Locate.Size = new System.Drawing.Size(75, 23);
            this.Locate.TabIndex = 3;
            this.Locate.Text = "Locate";
            this.Locate.UseVisualStyleBackColor = true;
            this.Locate.Click += new System.EventHandler(this.Locate_Click);
            // 
            // XCoordination
            // 
            this.XCoordination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XCoordination.Location = new System.Drawing.Point(51, 250);
            this.XCoordination.Maximum = 425;
            this.XCoordination.Name = "XCoordination";
            this.XCoordination.Size = new System.Drawing.Size(413, 45);
            this.XCoordination.TabIndex = 5;
            this.XCoordination.ValueChanged += new System.EventHandler(this.XCoordination_ValueChanged);
            // 
            // YCoordination
            // 
            this.YCoordination.Location = new System.Drawing.Point(4, 4);
            this.YCoordination.Maximum = 241;
            this.YCoordination.Name = "YCoordination";
            this.YCoordination.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.YCoordination.Size = new System.Drawing.Size(45, 243);
            this.YCoordination.TabIndex = 6;
            this.YCoordination.ValueChanged += new System.EventHandler(this.YCoordination_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.bmp)|*.bmp|(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif|(*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MouseOverCoordination
            // 
            this.MouseOverCoordination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MouseOverCoordination.AutoSize = true;
            this.MouseOverCoordination.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MouseOverCoordination.Location = new System.Drawing.Point(54, 296);
            this.MouseOverCoordination.Name = "MouseOverCoordination";
            this.MouseOverCoordination.Size = new System.Drawing.Size(47, 14);
            this.MouseOverCoordination.TabIndex = 7;
            this.MouseOverCoordination.Text = "(0,0)";
            // 
            // IfClear
            // 
            this.IfClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IfClear.AutoSize = true;
            this.IfClear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IfClear.Location = new System.Drawing.Point(56, 343);
            this.IfClear.Name = "IfClear";
            this.IfClear.Size = new System.Drawing.Size(114, 18);
            this.IfClear.TabIndex = 4;
            this.IfClear.Text = "clean marks";
            this.IfClear.UseVisualStyleBackColor = true;
            // 
            // MouseClickedCoordinationY
            // 
            this.MouseClickedCoordinationY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MouseClickedCoordinationY.Location = new System.Drawing.Point(112, 316);
            this.MouseClickedCoordinationY.Name = "MouseClickedCoordinationY";
            this.MouseClickedCoordinationY.Size = new System.Drawing.Size(29, 21);
            this.MouseClickedCoordinationY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(91, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = ",";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(273, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Choose a Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FreeCurve
            // 
            this.FreeCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FreeCurve.AutoSize = true;
            this.FreeCurve.Location = new System.Drawing.Point(208, 344);
            this.FreeCurve.Name = "FreeCurve";
            this.FreeCurve.Size = new System.Drawing.Size(83, 16);
            this.FreeCurve.TabIndex = 10;
            this.FreeCurve.TabStop = true;
            this.FreeCurve.Text = "Free Curve";
            this.FreeCurve.UseVisualStyleBackColor = true;
            this.FreeCurve.CheckedChanged += new System.EventHandler(this.FreeCurve_CheckedChanged);
            // 
            // Polyline
            // 
            this.Polyline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Polyline.AutoSize = true;
            this.Polyline.Location = new System.Drawing.Point(208, 367);
            this.Polyline.Name = "Polyline";
            this.Polyline.Size = new System.Drawing.Size(71, 16);
            this.Polyline.TabIndex = 11;
            this.Polyline.TabStop = true;
            this.Polyline.Text = "Polyline";
            this.Polyline.UseVisualStyleBackColor = true;
            this.Polyline.CheckedChanged += new System.EventHandler(this.Polyline_CheckedChanged);
            // 
            // ZCoordination
            // 
            this.ZCoordination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZCoordination.Location = new System.Drawing.Point(495, 27);
            this.ZCoordination.Maximum = 100;
            this.ZCoordination.Name = "ZCoordination";
            this.ZCoordination.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ZCoordination.Size = new System.Drawing.Size(45, 182);
            this.ZCoordination.TabIndex = 12;
            this.ZCoordination.ValueChanged += new System.EventHandler(this.ZCoordination_ValueChanged);
            // 
            // ZValue
            // 
            this.ZValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZValue.Location = new System.Drawing.Point(575, 27);
            this.ZValue.Name = "ZValue";
            this.ZValue.Size = new System.Drawing.Size(68, 21);
            this.ZValue.TabIndex = 13;
            // 
            // ZvalueOK
            // 
            this.ZvalueOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZvalueOK.Location = new System.Drawing.Point(658, 27);
            this.ZvalueOK.Name = "ZvalueOK";
            this.ZvalueOK.Size = new System.Drawing.Size(62, 21);
            this.ZvalueOK.TabIndex = 14;
            this.ZvalueOK.Text = "OK";
            this.ZvalueOK.UseVisualStyleBackColor = true;
            this.ZvalueOK.Click += new System.EventHandler(this.ZvalueOK_Click);
            // 
            // Zmax
            // 
            this.Zmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zmax.Location = new System.Drawing.Point(575, 108);
            this.Zmax.Name = "Zmax";
            this.Zmax.Size = new System.Drawing.Size(68, 21);
            this.Zmax.TabIndex = 15;
            // 
            // ZmaxOK
            // 
            this.ZmaxOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZmaxOK.Location = new System.Drawing.Point(658, 108);
            this.ZmaxOK.Name = "ZmaxOK";
            this.ZmaxOK.Size = new System.Drawing.Size(62, 21);
            this.ZmaxOK.TabIndex = 16;
            this.ZmaxOK.Text = "OK";
            this.ZmaxOK.UseVisualStyleBackColor = true;
            this.ZmaxOK.Click += new System.EventHandler(this.ZmaxOK_Click);
            // 
            // Speed
            // 
            this.Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Speed.Location = new System.Drawing.Point(575, 188);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(68, 21);
            this.Speed.TabIndex = 17;
            // 
            // SpeedOK
            // 
            this.SpeedOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedOK.Location = new System.Drawing.Point(658, 188);
            this.SpeedOK.Name = "SpeedOK";
            this.SpeedOK.Size = new System.Drawing.Size(62, 21);
            this.SpeedOK.TabIndex = 18;
            this.SpeedOK.Text = "OK";
            this.SpeedOK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Z";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "Zmax";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "Speed";
            // 
            // Run
            // 
            this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Run.Location = new System.Drawing.Point(612, 249);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(108, 46);
            this.Run.TabIndex = 22;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.Locate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeedOK);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.ZmaxOK);
            this.Controls.Add(this.Zmax);
            this.Controls.Add(this.ZvalueOK);
            this.Controls.Add(this.ZValue);
            this.Controls.Add(this.ZCoordination);
            this.Controls.Add(this.Polyline);
            this.Controls.Add(this.FreeCurve);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MouseClickedCoordinationY);
            this.Controls.Add(this.IfClear);
            this.Controls.Add(this.MouseOverCoordination);
            this.Controls.Add(this.YCoordination);
            this.Controls.Add(this.XCoordination);
            this.Controls.Add(this.Locate);
            this.Controls.Add(this.MouseClickedCoordinationX);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XCoordination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCoordination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZCoordination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MouseClickedCoordinationX;
        private System.Windows.Forms.Button Locate;
        private System.Windows.Forms.TrackBar XCoordination;
        private System.Windows.Forms.TrackBar YCoordination;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label MouseOverCoordination;
        private System.Windows.Forms.CheckBox IfClear;
        private System.Windows.Forms.TextBox MouseClickedCoordinationY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton FreeCurve;
        private System.Windows.Forms.RadioButton Polyline;
        private System.Windows.Forms.TrackBar ZCoordination;
        private System.Windows.Forms.TextBox ZValue;
        private System.Windows.Forms.Button ZvalueOK;
        private System.Windows.Forms.TextBox Zmax;
        private System.Windows.Forms.Button ZmaxOK;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Button SpeedOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Run;
    }
}

