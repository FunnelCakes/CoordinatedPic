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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XCoordination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCoordination)).BeginInit();
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
            this.IfClear.Size = new System.Drawing.Size(146, 18);
            this.IfClear.TabIndex = 4;
            this.IfClear.Text = "clean last mark";
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
            // Form1
            // 
            this.AcceptButton = this.Locate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 395);
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
    }
}

