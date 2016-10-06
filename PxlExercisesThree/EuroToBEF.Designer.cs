namespace PxlExercisesThree
{
    partial class EuroToBEF
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
            this.euroTxt = new System.Windows.Forms.TextBox();
            this.befText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.berekenen = new System.Windows.Forms.Button();
            this.wissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // euroTxt
            // 
            this.euroTxt.Location = new System.Drawing.Point(95, 12);
            this.euroTxt.Name = "euroTxt";
            this.euroTxt.Size = new System.Drawing.Size(100, 20);
            this.euroTxt.TabIndex = 0;
            // 
            // befText
            // 
            this.befText.Location = new System.Drawing.Point(95, 39);
            this.befText.Name = "befText";
            this.befText.ReadOnly = true;
            this.befText.Size = new System.Drawing.Size(100, 20);
            this.befText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bedrag in euro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bedrag in BEF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // berekenen
            // 
            this.berekenen.Location = new System.Drawing.Point(202, 8);
            this.berekenen.Name = "berekenen";
            this.berekenen.Size = new System.Drawing.Size(75, 23);
            this.berekenen.TabIndex = 4;
            this.berekenen.Text = "Bereken";
            this.berekenen.UseVisualStyleBackColor = true;
            this.berekenen.Click += new System.EventHandler(this.berekenen_Click);
            // 
            // wissen
            // 
            this.wissen.Location = new System.Drawing.Point(202, 35);
            this.wissen.Name = "wissen";
            this.wissen.Size = new System.Drawing.Size(75, 23);
            this.wissen.TabIndex = 5;
            this.wissen.Text = "Wissen";
            this.wissen.UseVisualStyleBackColor = true;
            this.wissen.Click += new System.EventHandler(this.wissen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 126);
            this.Controls.Add(this.wissen);
            this.Controls.Add(this.berekenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.befText);
            this.Controls.Add(this.euroTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox euroTxt;
        private System.Windows.Forms.TextBox befText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button berekenen;
        private System.Windows.Forms.Button wissen;
    }
}

