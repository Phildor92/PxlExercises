namespace CircleCalc
{
    partial class FrmMaandNamen
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
            this.txtMaanden = new System.Windows.Forms.TextBox();
            this.btnVulMetMaandNamen = new System.Windows.Forms.Button();
            this.btnGewoon = new System.Windows.Forms.Button();
            this.btnOmgekeerd = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnOneven = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnAlfabetisch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaanden
            // 
            this.txtMaanden.Location = new System.Drawing.Point(13, 13);
            this.txtMaanden.Multiline = true;
            this.txtMaanden.Name = "txtMaanden";
            this.txtMaanden.Size = new System.Drawing.Size(153, 236);
            this.txtMaanden.TabIndex = 0;
            // 
            // btnVulMetMaandNamen
            // 
            this.btnVulMetMaandNamen.Location = new System.Drawing.Point(13, 296);
            this.btnVulMetMaandNamen.Name = "btnVulMetMaandNamen";
            this.btnVulMetMaandNamen.Size = new System.Drawing.Size(119, 23);
            this.btnVulMetMaandNamen.TabIndex = 1;
            this.btnVulMetMaandNamen.Text = "Vul met maanden";
            this.btnVulMetMaandNamen.UseVisualStyleBackColor = true;
            this.btnVulMetMaandNamen.Click += new System.EventHandler(this.btnVulMetMaandNamen_Click);
            // 
            // btnGewoon
            // 
            this.btnGewoon.Location = new System.Drawing.Point(223, 45);
            this.btnGewoon.Name = "btnGewoon";
            this.btnGewoon.Size = new System.Drawing.Size(75, 23);
            this.btnGewoon.TabIndex = 2;
            this.btnGewoon.Text = "Gewoon";
            this.btnGewoon.UseVisualStyleBackColor = true;
            this.btnGewoon.Click += new System.EventHandler(this.btnGewoon_Click);
            // 
            // btnOmgekeerd
            // 
            this.btnOmgekeerd.Location = new System.Drawing.Point(223, 75);
            this.btnOmgekeerd.Name = "btnOmgekeerd";
            this.btnOmgekeerd.Size = new System.Drawing.Size(75, 23);
            this.btnOmgekeerd.TabIndex = 3;
            this.btnOmgekeerd.Text = "Omgekeerd";
            this.btnOmgekeerd.UseVisualStyleBackColor = true;
            this.btnOmgekeerd.Click += new System.EventHandler(this.btnOmgekeerd_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(223, 105);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(75, 23);
            this.btnEven.TabIndex = 4;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnOneven
            // 
            this.btnOneven.Location = new System.Drawing.Point(223, 135);
            this.btnOneven.Name = "btnOneven";
            this.btnOneven.Size = new System.Drawing.Size(75, 23);
            this.btnOneven.TabIndex = 5;
            this.btnOneven.Text = "Oneven";
            this.btnOneven.UseVisualStyleBackColor = true;
            this.btnOneven.Click += new System.EventHandler(this.btnOneven_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(223, 193);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 6;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(223, 222);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 7;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnAlfabetisch
            // 
            this.btnAlfabetisch.Location = new System.Drawing.Point(223, 164);
            this.btnAlfabetisch.Name = "btnAlfabetisch";
            this.btnAlfabetisch.Size = new System.Drawing.Size(75, 23);
            this.btnAlfabetisch.TabIndex = 8;
            this.btnAlfabetisch.Text = "Alfabetisch";
            this.btnAlfabetisch.UseVisualStyleBackColor = true;
            this.btnAlfabetisch.Click += new System.EventHandler(this.btnAlfabetisch_Click);
            // 
            // FrmMaandNamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 331);
            this.Controls.Add(this.btnAlfabetisch);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnOneven);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnOmgekeerd);
            this.Controls.Add(this.btnGewoon);
            this.Controls.Add(this.btnVulMetMaandNamen);
            this.Controls.Add(this.txtMaanden);
            this.Name = "FrmMaandNamen";
            this.Text = "FrmMaandNamen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaanden;
        private System.Windows.Forms.Button btnVulMetMaandNamen;
        private System.Windows.Forms.Button btnGewoon;
        private System.Windows.Forms.Button btnOmgekeerd;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnOneven;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnAlfabetisch;
    }
}