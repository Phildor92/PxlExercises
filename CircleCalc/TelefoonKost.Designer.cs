namespace CircleCalc
{
    partial class TelefoonKost
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
            this.beginUurTxt = new System.Windows.Forms.TextBox();
            this.beginMinuutTxt = new System.Windows.Forms.TextBox();
            this.eindUurTxt = new System.Windows.Forms.TextBox();
            this.eindMinTxt = new System.Windows.Forms.TextBox();
            this.soortGesprekTxt = new System.Windows.Forms.TextBox();
            this.berekenBtn = new System.Windows.Forms.Button();
            this.wissenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultaatTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // beginUurTxt
            // 
            this.beginUurTxt.Location = new System.Drawing.Point(94, 13);
            this.beginUurTxt.Name = "beginUurTxt";
            this.beginUurTxt.Size = new System.Drawing.Size(40, 20);
            this.beginUurTxt.TabIndex = 0;
            // 
            // beginMinuutTxt
            // 
            this.beginMinuutTxt.Location = new System.Drawing.Point(95, 39);
            this.beginMinuutTxt.Name = "beginMinuutTxt";
            this.beginMinuutTxt.Size = new System.Drawing.Size(39, 20);
            this.beginMinuutTxt.TabIndex = 1;
            // 
            // eindUurTxt
            // 
            this.eindUurTxt.Location = new System.Drawing.Point(95, 65);
            this.eindUurTxt.Name = "eindUurTxt";
            this.eindUurTxt.Size = new System.Drawing.Size(40, 20);
            this.eindUurTxt.TabIndex = 2;
            // 
            // eindMinTxt
            // 
            this.eindMinTxt.Location = new System.Drawing.Point(95, 91);
            this.eindMinTxt.Name = "eindMinTxt";
            this.eindMinTxt.Size = new System.Drawing.Size(39, 20);
            this.eindMinTxt.TabIndex = 3;
            // 
            // soortGesprekTxt
            // 
            this.soortGesprekTxt.Location = new System.Drawing.Point(95, 117);
            this.soortGesprekTxt.Name = "soortGesprekTxt";
            this.soortGesprekTxt.Size = new System.Drawing.Size(39, 20);
            this.soortGesprekTxt.TabIndex = 4;
            // 
            // berekenBtn
            // 
            this.berekenBtn.Location = new System.Drawing.Point(265, 33);
            this.berekenBtn.Name = "berekenBtn";
            this.berekenBtn.Size = new System.Drawing.Size(75, 23);
            this.berekenBtn.TabIndex = 5;
            this.berekenBtn.Text = "Bereken";
            this.berekenBtn.UseVisualStyleBackColor = true;
            this.berekenBtn.Click += new System.EventHandler(this.berekenBtn_Click);
            // 
            // wissenBtn
            // 
            this.wissenBtn.Location = new System.Drawing.Point(265, 62);
            this.wissenBtn.Name = "wissenBtn";
            this.wissenBtn.Size = new System.Drawing.Size(75, 23);
            this.wissenBtn.TabIndex = 6;
            this.wissenBtn.Text = "Wissen";
            this.wissenBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Z-zonaal, N-nationaal, I-internationaa, G-gsm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soort gesprek:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Eindminuut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Einduur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Beginminuut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Beginuur:";
            // 
            // resultaatTxt
            // 
            this.resultaatTxt.Location = new System.Drawing.Point(12, 151);
            this.resultaatTxt.Multiline = true;
            this.resultaatTxt.Name = "resultaatTxt";
            this.resultaatTxt.ReadOnly = true;
            this.resultaatTxt.Size = new System.Drawing.Size(346, 99);
            this.resultaatTxt.TabIndex = 13;
            // 
            // TelefoonKost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 262);
            this.Controls.Add(this.resultaatTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wissenBtn);
            this.Controls.Add(this.berekenBtn);
            this.Controls.Add(this.soortGesprekTxt);
            this.Controls.Add(this.eindMinTxt);
            this.Controls.Add(this.eindUurTxt);
            this.Controls.Add(this.beginMinuutTxt);
            this.Controls.Add(this.beginUurTxt);
            this.Name = "TelefoonKost";
            this.Text = "TelefoonKost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beginUurTxt;
        private System.Windows.Forms.TextBox beginMinuutTxt;
        private System.Windows.Forms.TextBox eindUurTxt;
        private System.Windows.Forms.TextBox eindMinTxt;
        private System.Windows.Forms.TextBox soortGesprekTxt;
        private System.Windows.Forms.Button berekenBtn;
        private System.Windows.Forms.Button wissenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultaatTxt;
    }
}