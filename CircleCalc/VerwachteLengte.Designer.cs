namespace CircleCalc
{
    partial class VerwachteLengte
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
            this.radBoy = new System.Windows.Forms.RadioButton();
            this.radGirl = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fatherTxt = new System.Windows.Forms.TextBox();
            this.motherTxt = new System.Windows.Forms.TextBox();
            this.boyTxt = new System.Windows.Forms.TextBox();
            this.girlTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bereken = new System.Windows.Forms.Button();
            this.sluiten = new System.Windows.Forms.Button();
            this.geslachtGrp = new System.Windows.Forms.GroupBox();
            this.jongenRad = new System.Windows.Forms.RadioButton();
            this.meisjeRad = new System.Windows.Forms.RadioButton();
            this.geslachtGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // radBoy
            // 
            this.radBoy.AutoSize = true;
            this.radBoy.Location = new System.Drawing.Point(12, 34);
            this.radBoy.Name = "radBoy";
            this.radBoy.Size = new System.Drawing.Size(60, 17);
            this.radBoy.TabIndex = 0;
            this.radBoy.TabStop = true;
            this.radBoy.Text = "Jongen";
            this.radBoy.UseVisualStyleBackColor = true;
            this.radBoy.CheckedChanged += new System.EventHandler(this.radBoy_CheckedChanged);
            // 
            // radGirl
            // 
            this.radGirl.AutoSize = true;
            this.radGirl.Location = new System.Drawing.Point(97, 34);
            this.radGirl.Name = "radGirl";
            this.radGirl.Size = new System.Drawing.Size(55, 17);
            this.radGirl.TabIndex = 1;
            this.radGirl.TabStop = true;
            this.radGirl.Text = "Meisje";
            this.radGirl.UseVisualStyleBackColor = true;
            this.radGirl.CheckedChanged += new System.EventHandler(this.radGirl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geslacht";
            // 
            // fatherTxt
            // 
            this.fatherTxt.Location = new System.Drawing.Point(184, 76);
            this.fatherTxt.Name = "fatherTxt";
            this.fatherTxt.Size = new System.Drawing.Size(100, 20);
            this.fatherTxt.TabIndex = 3;
            // 
            // motherTxt
            // 
            this.motherTxt.Location = new System.Drawing.Point(184, 103);
            this.motherTxt.Name = "motherTxt";
            this.motherTxt.Size = new System.Drawing.Size(100, 20);
            this.motherTxt.TabIndex = 4;
            // 
            // boyTxt
            // 
            this.boyTxt.Location = new System.Drawing.Point(184, 149);
            this.boyTxt.Name = "boyTxt";
            this.boyTxt.Size = new System.Drawing.Size(100, 20);
            this.boyTxt.TabIndex = 5;
            // 
            // girlTxt
            // 
            this.girlTxt.Location = new System.Drawing.Point(184, 176);
            this.girlTxt.Name = "girlTxt";
            this.girlTxt.ReadOnly = true;
            this.girlTxt.Size = new System.Drawing.Size(100, 20);
            this.girlTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lengte vader: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lengte moeder: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Verwachte lengte van jongen: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Verwachte lengte van meisje: ";
            // 
            // bereken
            // 
            this.bereken.Location = new System.Drawing.Point(334, 142);
            this.bereken.Name = "bereken";
            this.bereken.Size = new System.Drawing.Size(75, 23);
            this.bereken.TabIndex = 11;
            this.bereken.Text = "Berekenen";
            this.bereken.UseVisualStyleBackColor = true;
            this.bereken.Click += new System.EventHandler(this.bereken_Click);
            // 
            // sluiten
            // 
            this.sluiten.Location = new System.Drawing.Point(334, 172);
            this.sluiten.Name = "sluiten";
            this.sluiten.Size = new System.Drawing.Size(75, 23);
            this.sluiten.TabIndex = 12;
            this.sluiten.Text = "Sluiten";
            this.sluiten.UseVisualStyleBackColor = true;
            this.sluiten.Click += new System.EventHandler(this.sluiten_Click);
            // 
            // geslachtGrp
            // 
            this.geslachtGrp.Controls.Add(this.meisjeRad);
            this.geslachtGrp.Controls.Add(this.jongenRad);
            this.geslachtGrp.Location = new System.Drawing.Point(209, 12);
            this.geslachtGrp.Name = "geslachtGrp";
            this.geslachtGrp.Size = new System.Drawing.Size(200, 58);
            this.geslachtGrp.TabIndex = 13;
            this.geslachtGrp.TabStop = false;
            this.geslachtGrp.Text = "Geslacht";
            // 
            // jongenRad
            // 
            this.jongenRad.AutoSize = true;
            this.jongenRad.Location = new System.Drawing.Point(6, 22);
            this.jongenRad.Name = "jongenRad";
            this.jongenRad.Size = new System.Drawing.Size(60, 17);
            this.jongenRad.TabIndex = 0;
            this.jongenRad.TabStop = true;
            this.jongenRad.Text = "Jongen";
            this.jongenRad.UseVisualStyleBackColor = true;
            this.jongenRad.CheckedChanged += new System.EventHandler(this.jongenRad_CheckedChanged);
            // 
            // meisjeRad
            // 
            this.meisjeRad.AutoSize = true;
            this.meisjeRad.Location = new System.Drawing.Point(109, 22);
            this.meisjeRad.Name = "meisjeRad";
            this.meisjeRad.Size = new System.Drawing.Size(55, 17);
            this.meisjeRad.TabIndex = 1;
            this.meisjeRad.TabStop = true;
            this.meisjeRad.Text = "Meisje";
            this.meisjeRad.UseVisualStyleBackColor = true;
            this.meisjeRad.CheckedChanged += new System.EventHandler(this.meisjeRad_CheckedChanged);
            // 
            // VerwachteLengte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.geslachtGrp);
            this.Controls.Add(this.sluiten);
            this.Controls.Add(this.bereken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.girlTxt);
            this.Controls.Add(this.boyTxt);
            this.Controls.Add(this.motherTxt);
            this.Controls.Add(this.fatherTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGirl);
            this.Controls.Add(this.radBoy);
            this.Name = "VerwachteLengte";
            this.Text = "VerwachteLengte";
            this.Load += new System.EventHandler(this.VerwachteLengte_Load);
            this.geslachtGrp.ResumeLayout(false);
            this.geslachtGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBoy;
        private System.Windows.Forms.RadioButton radGirl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fatherTxt;
        private System.Windows.Forms.TextBox motherTxt;
        private System.Windows.Forms.TextBox boyTxt;
        private System.Windows.Forms.TextBox girlTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bereken;
        private System.Windows.Forms.Button sluiten;
        private System.Windows.Forms.GroupBox geslachtGrp;
        private System.Windows.Forms.RadioButton meisjeRad;
        private System.Windows.Forms.RadioButton jongenRad;
    }
}