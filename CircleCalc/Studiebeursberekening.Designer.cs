namespace CircleCalc
{
    partial class Studiebeursberekening
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
            this.naamTxt = new System.Windows.Forms.TextBox();
            this.brutobelastbaarTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bisStudentCb = new System.Windows.Forms.CheckBox();
            this.kotstudentCb = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kunOpleidingRad = new System.Windows.Forms.RadioButton();
            this.techOpleidingRad = new System.Windows.Forms.RadioButton();
            this.algOpleidingRad = new System.Windows.Forms.RadioButton();
            this.berekenBtn = new System.Windows.Forms.Button();
            this.resultaatTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aantalKinderenTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Studie Beurs Berekening";
            // 
            // naamTxt
            // 
            this.naamTxt.Location = new System.Drawing.Point(211, 46);
            this.naamTxt.Name = "naamTxt";
            this.naamTxt.Size = new System.Drawing.Size(100, 20);
            this.naamTxt.TabIndex = 1;
            // 
            // brutobelastbaarTxt
            // 
            this.brutobelastbaarTxt.Location = new System.Drawing.Point(211, 98);
            this.brutobelastbaarTxt.Name = "brutobelastbaarTxt";
            this.brutobelastbaarTxt.Size = new System.Drawing.Size(100, 20);
            this.brutobelastbaarTxt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bisStudentCb);
            this.groupBox1.Controls.Add(this.kotstudentCb);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bisStudentCb
            // 
            this.bisStudentCb.AutoSize = true;
            this.bisStudentCb.Location = new System.Drawing.Point(7, 44);
            this.bisStudentCb.Name = "bisStudentCb";
            this.bisStudentCb.Size = new System.Drawing.Size(109, 17);
            this.bisStudentCb.TabIndex = 1;
            this.bisStudentCb.Text = ">50% bisstudent?";
            this.bisStudentCb.UseVisualStyleBackColor = true;
            // 
            // kotstudentCb
            // 
            this.kotstudentCb.AutoSize = true;
            this.kotstudentCb.Location = new System.Drawing.Point(7, 20);
            this.kotstudentCb.Name = "kotstudentCb";
            this.kotstudentCb.Size = new System.Drawing.Size(82, 17);
            this.kotstudentCb.TabIndex = 0;
            this.kotstudentCb.Text = "kotstudent?";
            this.kotstudentCb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kunOpleidingRad);
            this.groupBox2.Controls.Add(this.techOpleidingRad);
            this.groupBox2.Controls.Add(this.algOpleidingRad);
            this.groupBox2.Location = new System.Drawing.Point(263, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // kunOpleidingRad
            // 
            this.kunOpleidingRad.AutoSize = true;
            this.kunOpleidingRad.Location = new System.Drawing.Point(7, 68);
            this.kunOpleidingRad.Name = "kunOpleidingRad";
            this.kunOpleidingRad.Size = new System.Drawing.Size(97, 17);
            this.kunOpleidingRad.TabIndex = 2;
            this.kunOpleidingRad.TabStop = true;
            this.kunOpleidingRad.Text = "Kunst opleiding";
            this.kunOpleidingRad.UseVisualStyleBackColor = true;
            // 
            // techOpleidingRad
            // 
            this.techOpleidingRad.AutoSize = true;
            this.techOpleidingRad.Location = new System.Drawing.Point(7, 44);
            this.techOpleidingRad.Name = "techOpleidingRad";
            this.techOpleidingRad.Size = new System.Drawing.Size(126, 17);
            this.techOpleidingRad.TabIndex = 1;
            this.techOpleidingRad.TabStop = true;
            this.techOpleidingRad.Text = "Technische opleiding";
            this.techOpleidingRad.UseVisualStyleBackColor = true;
            // 
            // algOpleidingRad
            // 
            this.algOpleidingRad.AutoSize = true;
            this.algOpleidingRad.Location = new System.Drawing.Point(7, 20);
            this.algOpleidingRad.Name = "algOpleidingRad";
            this.algOpleidingRad.Size = new System.Drawing.Size(117, 17);
            this.algOpleidingRad.TabIndex = 0;
            this.algOpleidingRad.TabStop = true;
            this.algOpleidingRad.Text = "Algemene opleiding";
            this.algOpleidingRad.UseVisualStyleBackColor = true;
            // 
            // berekenBtn
            // 
            this.berekenBtn.Location = new System.Drawing.Point(387, 355);
            this.berekenBtn.Name = "berekenBtn";
            this.berekenBtn.Size = new System.Drawing.Size(75, 23);
            this.berekenBtn.TabIndex = 5;
            this.berekenBtn.Text = "Bereken";
            this.berekenBtn.UseVisualStyleBackColor = true;
            this.berekenBtn.Click += new System.EventHandler(this.berekenBtn_Click);
            // 
            // resultaatTxt
            // 
            this.resultaatTxt.Location = new System.Drawing.Point(12, 235);
            this.resultaatTxt.Multiline = true;
            this.resultaatTxt.Name = "resultaatTxt";
            this.resultaatTxt.ReadOnly = true;
            this.resultaatTxt.Size = new System.Drawing.Size(369, 143);
            this.resultaatTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brutobelastbaar";
            // 
            // aantalKinderenTxt
            // 
            this.aantalKinderenTxt.Location = new System.Drawing.Point(211, 72);
            this.aantalKinderenTxt.Name = "aantalKinderenTxt";
            this.aantalKinderenTxt.Size = new System.Drawing.Size(100, 20);
            this.aantalKinderenTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aantal kinderen";
            // 
            // Studiebeursberekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aantalKinderenTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultaatTxt);
            this.Controls.Add(this.berekenBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.brutobelastbaarTxt);
            this.Controls.Add(this.naamTxt);
            this.Controls.Add(this.label1);
            this.Name = "Studiebeursberekening";
            this.Text = "Studiebeursberekening";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox naamTxt;
        private System.Windows.Forms.TextBox brutobelastbaarTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox bisStudentCb;
        private System.Windows.Forms.CheckBox kotstudentCb;
        private System.Windows.Forms.RadioButton kunOpleidingRad;
        private System.Windows.Forms.RadioButton techOpleidingRad;
        private System.Windows.Forms.RadioButton algOpleidingRad;
        private System.Windows.Forms.Button berekenBtn;
        private System.Windows.Forms.TextBox resultaatTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aantalKinderenTxt;
        private System.Windows.Forms.Label label4;
    }
}