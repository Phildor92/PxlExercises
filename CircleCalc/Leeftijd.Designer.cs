namespace CircleCalc
{
    partial class Leeftijd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dagTxt = new System.Windows.Forms.TextBox();
            this.maandTxt = new System.Windows.Forms.TextBox();
            this.jaarTxt = new System.Windows.Forms.TextBox();
            this.geboorteTxt = new System.Windows.Forms.TextBox();
            this.bereken = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTijd = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dagTxt);
            this.panel1.Controls.Add(this.maandTxt);
            this.panel1.Controls.Add(this.jaarTxt);
            this.panel1.Location = new System.Drawing.Point(41, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 113);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dagen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maanden:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jaren:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dagTxt
            // 
            this.dagTxt.Location = new System.Drawing.Point(113, 76);
            this.dagTxt.Name = "dagTxt";
            this.dagTxt.ReadOnly = true;
            this.dagTxt.Size = new System.Drawing.Size(100, 20);
            this.dagTxt.TabIndex = 2;
            // 
            // maandTxt
            // 
            this.maandTxt.Location = new System.Drawing.Point(113, 49);
            this.maandTxt.Name = "maandTxt";
            this.maandTxt.ReadOnly = true;
            this.maandTxt.Size = new System.Drawing.Size(100, 20);
            this.maandTxt.TabIndex = 1;
            // 
            // jaarTxt
            // 
            this.jaarTxt.Location = new System.Drawing.Point(113, 22);
            this.jaarTxt.Name = "jaarTxt";
            this.jaarTxt.ReadOnly = true;
            this.jaarTxt.Size = new System.Drawing.Size(100, 20);
            this.jaarTxt.TabIndex = 0;
            // 
            // geboorteTxt
            // 
            this.geboorteTxt.Location = new System.Drawing.Point(154, 49);
            this.geboorteTxt.Name = "geboorteTxt";
            this.geboorteTxt.Size = new System.Drawing.Size(100, 20);
            this.geboorteTxt.TabIndex = 1;
            // 
            // bereken
            // 
            this.bereken.Location = new System.Drawing.Point(260, 46);
            this.bereken.Name = "bereken";
            this.bereken.Size = new System.Drawing.Size(75, 23);
            this.bereken.TabIndex = 2;
            this.bereken.Text = "Bereken";
            this.bereken.UseVisualStyleBackColor = true;
            this.bereken.Click += new System.EventHandler(this.bereken_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geboortedatum";
            // 
            // lblTijd
            // 
            this.lblTijd.AutoSize = true;
            this.lblTijd.Location = new System.Drawing.Point(273, 9);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(49, 13);
            this.lblTijd.TabIndex = 4;
            this.lblTijd.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Leeftijd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 262);
            this.Controls.Add(this.lblTijd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bereken);
            this.Controls.Add(this.geboorteTxt);
            this.Controls.Add(this.panel1);
            this.Name = "Leeftijd";
            this.Text = "Leeftijd in jaren, maanden en dagen";
            this.Load += new System.EventHandler(this.Leeftijd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dagTxt;
        private System.Windows.Forms.TextBox maandTxt;
        private System.Windows.Forms.TextBox jaarTxt;
        private System.Windows.Forms.TextBox geboorteTxt;
        private System.Windows.Forms.Button bereken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTijd;
        private System.Windows.Forms.Timer timer1;
    }
}