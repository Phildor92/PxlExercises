namespace CircleCalc
{
    partial class CursusGeld
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jaarTxt = new System.Windows.Forms.TextBox();
            this.lesuurTxt = new System.Windows.Forms.TextBox();
            this.geldTxt = new System.Windows.Forms.TextBox();
            this.testNumeriek = new System.Windows.Forms.Button();
            this.bereken = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.isNum = new System.Windows.Forms.Label();
            this.isLeap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jaar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal lesuren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cursusgeld";
            // 
            // jaarTxt
            // 
            this.jaarTxt.Location = new System.Drawing.Point(90, 5);
            this.jaarTxt.Name = "jaarTxt";
            this.jaarTxt.Size = new System.Drawing.Size(100, 20);
            this.jaarTxt.TabIndex = 3;
            this.jaarTxt.TextChanged += new System.EventHandler(this.jaarTxt_TextChanged);
            // 
            // lesuurTxt
            // 
            this.lesuurTxt.Location = new System.Drawing.Point(90, 31);
            this.lesuurTxt.Name = "lesuurTxt";
            this.lesuurTxt.Size = new System.Drawing.Size(100, 20);
            this.lesuurTxt.TabIndex = 4;
            // 
            // geldTxt
            // 
            this.geldTxt.Location = new System.Drawing.Point(90, 59);
            this.geldTxt.Name = "geldTxt";
            this.geldTxt.Size = new System.Drawing.Size(100, 20);
            this.geldTxt.TabIndex = 5;
            // 
            // testNumeriek
            // 
            this.testNumeriek.Location = new System.Drawing.Point(13, 107);
            this.testNumeriek.Name = "testNumeriek";
            this.testNumeriek.Size = new System.Drawing.Size(96, 23);
            this.testNumeriek.TabIndex = 6;
            this.testNumeriek.Text = "Test Numeriek";
            this.testNumeriek.UseVisualStyleBackColor = true;
            this.testNumeriek.Click += new System.EventHandler(this.testNumeriek_Click);
            // 
            // bereken
            // 
            this.bereken.Location = new System.Drawing.Point(125, 107);
            this.bereken.Name = "bereken";
            this.bereken.Size = new System.Drawing.Size(75, 23);
            this.bereken.TabIndex = 7;
            this.bereken.Text = "Bereken";
            this.bereken.UseVisualStyleBackColor = true;
            this.bereken.Click += new System.EventHandler(this.bereken_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(215, 107);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "Afsluiten";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // isNum
            // 
            this.isNum.AutoSize = true;
            this.isNum.Location = new System.Drawing.Point(212, 9);
            this.isNum.Name = "isNum";
            this.isNum.Size = new System.Drawing.Size(61, 13);
            this.isNum.TabIndex = 9;
            this.isNum.Text = "Is numeriek";
            // 
            // isLeap
            // 
            this.isLeap.AutoSize = true;
            this.isLeap.Location = new System.Drawing.Point(212, 34);
            this.isLeap.Name = "isLeap";
            this.isLeap.Size = new System.Drawing.Size(98, 13);
            this.isLeap.TabIndex = 10;
            this.isLeap.Text = "Is een schrikkeljaar";
            this.isLeap.Visible = false;
            // 
            // CursusGeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 149);
            this.Controls.Add(this.isLeap);
            this.Controls.Add(this.isNum);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bereken);
            this.Controls.Add(this.testNumeriek);
            this.Controls.Add(this.geldTxt);
            this.Controls.Add(this.lesuurTxt);
            this.Controls.Add(this.jaarTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CursusGeld";
            this.Text = "CursusGeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jaarTxt;
        private System.Windows.Forms.TextBox lesuurTxt;
        private System.Windows.Forms.TextBox geldTxt;
        private System.Windows.Forms.Button testNumeriek;
        private System.Windows.Forms.Button bereken;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label isNum;
        private System.Windows.Forms.Label isLeap;
    }
}