namespace CircleCalc
{
    partial class Parking
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
            this.inBtn = new System.Windows.Forms.Button();
            this.uitBtn = new System.Windows.Forms.Button();
            this.resultaatTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inBtn
            // 
            this.inBtn.Location = new System.Drawing.Point(73, 64);
            this.inBtn.Name = "inBtn";
            this.inBtn.Size = new System.Drawing.Size(75, 23);
            this.inBtn.TabIndex = 0;
            this.inBtn.Text = "Binnenrijden";
            this.inBtn.UseVisualStyleBackColor = true;
            this.inBtn.Click += new System.EventHandler(this.inBtn_Click);
            // 
            // uitBtn
            // 
            this.uitBtn.Location = new System.Drawing.Point(214, 63);
            this.uitBtn.Name = "uitBtn";
            this.uitBtn.Size = new System.Drawing.Size(75, 23);
            this.uitBtn.TabIndex = 1;
            this.uitBtn.Text = "Buitenrijden";
            this.uitBtn.UseVisualStyleBackColor = true;
            this.uitBtn.Click += new System.EventHandler(this.uitBtn_Click);
            // 
            // resultaatTxt
            // 
            this.resultaatTxt.Location = new System.Drawing.Point(73, 123);
            this.resultaatTxt.Multiline = true;
            this.resultaatTxt.Name = "resultaatTxt";
            this.resultaatTxt.ReadOnly = true;
            this.resultaatTxt.Size = new System.Drawing.Size(216, 93);
            this.resultaatTxt.TabIndex = 2;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.resultaatTxt);
            this.Controls.Add(this.uitBtn);
            this.Controls.Add(this.inBtn);
            this.Name = "Parking";
            this.Text = "Parking";
            this.Load += new System.EventHandler(this.Parking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inBtn;
        private System.Windows.Forms.Button uitBtn;
        private System.Windows.Forms.TextBox resultaatTxt;
    }
}