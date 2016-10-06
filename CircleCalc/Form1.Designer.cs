namespace CircleCalc
{
    partial class Form1
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
            this.radiusTxt = new System.Windows.Forms.TextBox();
            this.surfaceTxt = new System.Windows.Forms.TextBox();
            this.cirmcumferenceTxt = new System.Windows.Forms.TextBox();
            this.bereken = new System.Windows.Forms.Button();
            this.wissen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiusTxt
            // 
            this.radiusTxt.Location = new System.Drawing.Point(113, 12);
            this.radiusTxt.Name = "radiusTxt";
            this.radiusTxt.Size = new System.Drawing.Size(100, 20);
            this.radiusTxt.TabIndex = 0;
            // 
            // surfaceTxt
            // 
            this.surfaceTxt.Location = new System.Drawing.Point(113, 40);
            this.surfaceTxt.Name = "surfaceTxt";
            this.surfaceTxt.ReadOnly = true;
            this.surfaceTxt.Size = new System.Drawing.Size(100, 20);
            this.surfaceTxt.TabIndex = 1;
            // 
            // cirmcumferenceTxt
            // 
            this.cirmcumferenceTxt.Location = new System.Drawing.Point(113, 67);
            this.cirmcumferenceTxt.Name = "cirmcumferenceTxt";
            this.cirmcumferenceTxt.ReadOnly = true;
            this.cirmcumferenceTxt.Size = new System.Drawing.Size(100, 20);
            this.cirmcumferenceTxt.TabIndex = 2;
            // 
            // bereken
            // 
            this.bereken.Location = new System.Drawing.Point(240, 26);
            this.bereken.Name = "bereken";
            this.bereken.Size = new System.Drawing.Size(75, 23);
            this.bereken.TabIndex = 3;
            this.bereken.Text = "Bereken";
            this.bereken.UseVisualStyleBackColor = true;
            this.bereken.Click += new System.EventHandler(this.bereken_Click);
            // 
            // wissen
            // 
            this.wissen.Location = new System.Drawing.Point(240, 56);
            this.wissen.Name = "wissen";
            this.wissen.Size = new System.Drawing.Size(75, 23);
            this.wissen.TabIndex = 4;
            this.wissen.Text = "Wissen";
            this.wissen.UseVisualStyleBackColor = true;
            this.wissen.Click += new System.EventHandler(this.wissen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Straal (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Oppervlakte (cm2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Omtrek (cm)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 148);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wissen);
            this.Controls.Add(this.bereken);
            this.Controls.Add(this.cirmcumferenceTxt);
            this.Controls.Add(this.surfaceTxt);
            this.Controls.Add(this.radiusTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radiusTxt;
        private System.Windows.Forms.TextBox surfaceTxt;
        private System.Windows.Forms.TextBox cirmcumferenceTxt;
        private System.Windows.Forms.Button bereken;
        private System.Windows.Forms.Button wissen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

