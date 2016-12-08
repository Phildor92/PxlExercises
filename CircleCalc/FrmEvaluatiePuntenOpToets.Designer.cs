namespace CircleCalc
{
    partial class FrmEvaluatiePuntenOpToets
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start ingave en berekening";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start/stop wijzigen achtergrondkleur";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(13, 60);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.Size = new System.Drawing.Size(412, 262);
            this.txtResultaat.TabIndex = 2;
            // 
            // FrmEvaluatiePuntenOpToets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 334);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmEvaluatiePuntenOpToets";
            this.Text = "FrmEvaluatiePuntenOpToets";
            this.Load += new System.EventHandler(this.FrmEvaluatiePuntenOpToets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultaat;
    }
}