namespace CircleCalc
{
    partial class Falculteit
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
            this.getalTxt = new System.Windows.Forms.TextBox();
            this.resultaatTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.berekenBtn = new System.Windows.Forms.Button();
            this.wissenBtn = new System.Windows.Forms.Button();
            this.sluitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getalTxt
            // 
            this.getalTxt.Location = new System.Drawing.Point(26, 68);
            this.getalTxt.Name = "getalTxt";
            this.getalTxt.Size = new System.Drawing.Size(100, 20);
            this.getalTxt.TabIndex = 0;
            // 
            // resultaatTxt
            // 
            this.resultaatTxt.Location = new System.Drawing.Point(26, 148);
            this.resultaatTxt.Name = "resultaatTxt";
            this.resultaatTxt.Size = new System.Drawing.Size(194, 20);
            this.resultaatTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Getal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultaat";
            // 
            // berekenBtn
            // 
            this.berekenBtn.Location = new System.Drawing.Point(26, 222);
            this.berekenBtn.Name = "berekenBtn";
            this.berekenBtn.Size = new System.Drawing.Size(75, 23);
            this.berekenBtn.TabIndex = 4;
            this.berekenBtn.Text = "Bereken";
            this.berekenBtn.UseVisualStyleBackColor = true;
            this.berekenBtn.Click += new System.EventHandler(this.berekenBtn_Click);
            // 
            // wissenBtn
            // 
            this.wissenBtn.Location = new System.Drawing.Point(107, 222);
            this.wissenBtn.Name = "wissenBtn";
            this.wissenBtn.Size = new System.Drawing.Size(75, 23);
            this.wissenBtn.TabIndex = 5;
            this.wissenBtn.Text = "Wissen";
            this.wissenBtn.UseVisualStyleBackColor = true;
            // 
            // sluitBtn
            // 
            this.sluitBtn.Location = new System.Drawing.Point(188, 222);
            this.sluitBtn.Name = "sluitBtn";
            this.sluitBtn.Size = new System.Drawing.Size(75, 23);
            this.sluitBtn.TabIndex = 6;
            this.sluitBtn.Text = "Sluiten";
            this.sluitBtn.UseVisualStyleBackColor = true;
            // 
            // Falculteit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sluitBtn);
            this.Controls.Add(this.wissenBtn);
            this.Controls.Add(this.berekenBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultaatTxt);
            this.Controls.Add(this.getalTxt);
            this.Name = "Falculteit";
            this.Text = "Falculteit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox getalTxt;
        private System.Windows.Forms.TextBox resultaatTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button berekenBtn;
        private System.Windows.Forms.Button wissenBtn;
        private System.Windows.Forms.Button sluitBtn;
    }
}