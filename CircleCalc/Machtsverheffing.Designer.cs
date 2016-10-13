namespace CircleCalc
{
    partial class Machtsverheffing
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
            this.getalTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultaatTxt = new System.Windows.Forms.TextBox();
            this.sluitenBtn = new System.Windows.Forms.Button();
            this.wissenBtn = new System.Windows.Forms.Button();
            this.berekenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // getalTxt
            // 
            this.getalTxt.Location = new System.Drawing.Point(29, 41);
            this.getalTxt.Name = "getalTxt";
            this.getalTxt.Size = new System.Drawing.Size(100, 20);
            this.getalTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultaat";
            // 
            // resultaatTxt
            // 
            this.resultaatTxt.Location = new System.Drawing.Point(29, 98);
            this.resultaatTxt.Multiline = true;
            this.resultaatTxt.Name = "resultaatTxt";
            this.resultaatTxt.Size = new System.Drawing.Size(227, 173);
            this.resultaatTxt.TabIndex = 3;
            // 
            // sluitenBtn
            // 
            this.sluitenBtn.Location = new System.Drawing.Point(262, 208);
            this.sluitenBtn.Name = "sluitenBtn";
            this.sluitenBtn.Size = new System.Drawing.Size(75, 23);
            this.sluitenBtn.TabIndex = 4;
            this.sluitenBtn.Text = "Sluiten";
            this.sluitenBtn.UseVisualStyleBackColor = true;
            this.sluitenBtn.Click += new System.EventHandler(this.sluitenBtn_Click);
            // 
            // wissenBtn
            // 
            this.wissenBtn.Location = new System.Drawing.Point(262, 179);
            this.wissenBtn.Name = "wissenBtn";
            this.wissenBtn.Size = new System.Drawing.Size(75, 23);
            this.wissenBtn.TabIndex = 5;
            this.wissenBtn.Text = "Wissen";
            this.wissenBtn.UseVisualStyleBackColor = true;
            this.wissenBtn.Click += new System.EventHandler(this.wissenBtn_Click);
            // 
            // berekenBtn
            // 
            this.berekenBtn.Location = new System.Drawing.Point(262, 150);
            this.berekenBtn.Name = "berekenBtn";
            this.berekenBtn.Size = new System.Drawing.Size(75, 23);
            this.berekenBtn.TabIndex = 6;
            this.berekenBtn.Text = "Bereken";
            this.berekenBtn.UseVisualStyleBackColor = true;
            this.berekenBtn.Click += new System.EventHandler(this.berekenBtn_Click);
            // 
            // Machtsverheffing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 283);
            this.Controls.Add(this.berekenBtn);
            this.Controls.Add(this.wissenBtn);
            this.Controls.Add(this.sluitenBtn);
            this.Controls.Add(this.resultaatTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getalTxt);
            this.Controls.Add(this.label1);
            this.Name = "Machtsverheffing";
            this.Text = "Machtsverheffing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getalTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultaatTxt;
        private System.Windows.Forms.Button sluitenBtn;
        private System.Windows.Forms.Button wissenBtn;
        private System.Windows.Forms.Button berekenBtn;
    }
}