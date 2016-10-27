namespace CircleCalc
{
    partial class Lotto
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
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnEinde = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart3 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(13, 13);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultaat.Size = new System.Drawing.Size(269, 305);
            this.txtResultaat.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(380, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Zonder Lus";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(289, 43);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 2;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            // 
            // btnEinde
            // 
            this.btnEinde.Location = new System.Drawing.Point(289, 73);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 3;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = true;
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(289, 14);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 23);
            this.btnStart2.TabIndex = 4;
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart3
            // 
            this.btnStart3.Location = new System.Drawing.Point(380, 57);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(75, 23);
            this.btnStart3.TabIndex = 5;
            this.btnStart3.Text = "Start3";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(380, 87);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 330);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart3);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnEinde);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtResultaat);
            this.Name = "Lotto";
            this.Text = "Lotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart3;
        private System.Windows.Forms.Button btnStop;
    }
}