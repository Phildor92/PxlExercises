namespace CircleCalc
{
    partial class TrackbarTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackbarTimer));
            this.btnToggle = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.imgRandLoc = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label0 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRandLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(327, 217);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(81, 45);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "Verplaatsen of laten staan";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 217);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(293, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.Value = 25;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // imgRandLoc
            // 
            this.imgRandLoc.Image = ((System.Drawing.Image)(resources.GetObject("imgRandLoc.Image")));
            this.imgRandLoc.Location = new System.Drawing.Point(124, 69);
            this.imgRandLoc.Name = "imgRandLoc";
            this.imgRandLoc.Size = new System.Drawing.Size(77, 72);
            this.imgRandLoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRandLoc.TabIndex = 2;
            this.imgRandLoc.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(21, 249);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(13, 13);
            this.label0.TabIndex = 3;
            this.label0.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(151, 249);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "25";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(287, 249);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(19, 13);
            this.label50.TabIndex = 5;
            this.label50.Text = "50";
            // 
            // TrackbarTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 435);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.imgRandLoc);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnToggle);
            this.Name = "TrackbarTimer";
            this.Text = "TrackbarTimer";
            this.Load += new System.EventHandler(this.TrackbarTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRandLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox imgRandLoc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}