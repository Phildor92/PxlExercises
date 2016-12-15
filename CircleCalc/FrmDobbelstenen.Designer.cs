namespace CircleCalc
{
    partial class FrmDobbelstenen
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
            this.btnWorp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorp = new System.Windows.Forms.TextBox();
            this.txt100Worpen = new System.Windows.Forms.TextBox();
            this.rollTimer = new System.Windows.Forms.Timer(this.components);
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKiesAantal = new System.Windows.Forms.TextBox();
            this.btnToggleDebug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWorp
            // 
            this.btnWorp.Location = new System.Drawing.Point(315, 65);
            this.btnWorp.Name = "btnWorp";
            this.btnWorp.Size = new System.Drawing.Size(84, 23);
            this.btnWorp.TabIndex = 0;
            this.btnWorp.Text = "Een Worp";
            this.btnWorp.UseVisualStyleBackColor = true;
            this.btnWorp.Click += new System.EventHandler(this.btnWorp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start Timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(452, 12);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(60, 20);
            this.txtInterval.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geef het interval";
            // 
            // txtWorp
            // 
            this.txtWorp.Location = new System.Drawing.Point(13, 67);
            this.txtWorp.Name = "txtWorp";
            this.txtWorp.ReadOnly = true;
            this.txtWorp.Size = new System.Drawing.Size(253, 20);
            this.txtWorp.TabIndex = 4;
            // 
            // txt100Worpen
            // 
            this.txt100Worpen.Location = new System.Drawing.Point(13, 94);
            this.txt100Worpen.Multiline = true;
            this.txt100Worpen.Name = "txt100Worpen";
            this.txt100Worpen.ReadOnly = true;
            this.txt100Worpen.Size = new System.Drawing.Size(279, 331);
            this.txt100Worpen.TabIndex = 5;
            // 
            // rollTimer
            // 
            this.rollTimer.Tick += new System.EventHandler(this.rollTimer_Tick);
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(315, 94);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ReadOnly = true;
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebug.Size = new System.Drawing.Size(100, 310);
            this.txtDebug.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Geef het aantal";
            // 
            // txtKiesAantal
            // 
            this.txtKiesAantal.Location = new System.Drawing.Point(452, 39);
            this.txtKiesAantal.Name = "txtKiesAantal";
            this.txtKiesAantal.Size = new System.Drawing.Size(60, 20);
            this.txtKiesAantal.TabIndex = 8;
            // 
            // btnToggleDebug
            // 
            this.btnToggleDebug.Location = new System.Drawing.Point(437, 95);
            this.btnToggleDebug.Name = "btnToggleDebug";
            this.btnToggleDebug.Size = new System.Drawing.Size(84, 23);
            this.btnToggleDebug.TabIndex = 9;
            this.btnToggleDebug.Text = "Toggle debug";
            this.btnToggleDebug.UseVisualStyleBackColor = true;
            this.btnToggleDebug.Click += new System.EventHandler(this.btnToggleDebug_Click);
            // 
            // FrmDobbelstenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 437);
            this.Controls.Add(this.btnToggleDebug);
            this.Controls.Add(this.txtKiesAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.txt100Worpen);
            this.Controls.Add(this.txtWorp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnWorp);
            this.Name = "FrmDobbelstenen";
            this.Text = "FrmDobbelstenen";
            this.Load += new System.EventHandler(this.FrmDobbelstenen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorp;
        private System.Windows.Forms.TextBox txt100Worpen;
        private System.Windows.Forms.Timer rollTimer;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKiesAantal;
        private System.Windows.Forms.Button btnToggleDebug;
    }
}