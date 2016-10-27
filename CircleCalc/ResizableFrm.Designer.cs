namespace CircleCalc
{
    partial class ResizableFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizableFrm));
            this.resizeImg = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtWaarde = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resizeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // resizeImg
            // 
            this.resizeImg.Image = global::CircleCalc.Properties.Resources.beeld_20;
            this.resizeImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("resizeImg.InitialImage")));
            this.resizeImg.Location = new System.Drawing.Point(13, 12);
            this.resizeImg.Name = "resizeImg";
            this.resizeImg.Size = new System.Drawing.Size(166, 100);
            this.resizeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeImg.TabIndex = 0;
            this.resizeImg.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 406);
            this.trackBar1.Maximum = 800;
            this.trackBar1.Minimum = 166;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(441, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 166;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtWaarde
            // 
            this.txtWaarde.Location = new System.Drawing.Point(13, 457);
            this.txtWaarde.Name = "txtWaarde";
            this.txtWaarde.Size = new System.Drawing.Size(61, 20);
            this.txtWaarde.TabIndex = 2;
            // 
            // ResizableFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 489);
            this.Controls.Add(this.txtWaarde);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.resizeImg);
            this.Name = "ResizableFrm";
            this.Text = "ResizableFrm";
            this.Load += new System.EventHandler(this.ResizableFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resizeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resizeImg;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtWaarde;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}