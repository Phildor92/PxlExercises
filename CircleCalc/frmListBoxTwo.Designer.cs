namespace CircleCalc
{
    partial class FrmListBoxTwo
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
            this.btnSorteren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnVervangen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSimple = new System.Windows.Forms.ListBox();
            this.txtZoeken = new System.Windows.Forms.TextBox();
            this.txtToevoegen = new System.Windows.Forms.TextBox();
            this.txtVervangen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblZoeken = new System.Windows.Forms.Label();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.chlstCheckedLB = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSorteren
            // 
            this.btnSorteren.Location = new System.Drawing.Point(196, 59);
            this.btnSorteren.Name = "btnSorteren";
            this.btnSorteren.Size = new System.Drawing.Size(75, 23);
            this.btnSorteren.TabIndex = 0;
            this.btnSorteren.Text = "Sorteren";
            this.btnSorteren.UseVisualStyleBackColor = true;
            this.btnSorteren.Click += new System.EventHandler(this.btnSorteren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(196, 89);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderen.TabIndex = 1;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(196, 119);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 2;
            this.btnWissen.Text = "LB Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // btnVervangen
            // 
            this.btnVervangen.Location = new System.Drawing.Point(196, 149);
            this.btnVervangen.Name = "btnVervangen";
            this.btnVervangen.Size = new System.Drawing.Size(75, 23);
            this.btnVervangen.TabIndex = 3;
            this.btnVervangen.Text = "Vervangen";
            this.btnVervangen.UseVisualStyleBackColor = true;
            this.btnVervangen.Click += new System.EventHandler(this.btnVervangen_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(196, 179);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 4;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(196, 209);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(75, 23);
            this.btnZoeken.TabIndex = 5;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblZoeken);
            this.groupBox1.Controls.Add(this.txtVervangen);
            this.groupBox1.Controls.Add(this.txtToevoegen);
            this.groupBox1.Controls.Add(this.txtZoeken);
            this.groupBox1.Controls.Add(this.lstSimple);
            this.groupBox1.Controls.Add(this.btnToevoegen);
            this.groupBox1.Controls.Add(this.btnZoeken);
            this.groupBox1.Controls.Add(this.btnSorteren);
            this.groupBox1.Controls.Add(this.btnVerwijderen);
            this.groupBox1.Controls.Add(this.btnVervangen);
            this.groupBox1.Controls.Add(this.btnWissen);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 238);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple Listbox";
            // 
            // lstSimple
            // 
            this.lstSimple.FormattingEnabled = true;
            this.lstSimple.Location = new System.Drawing.Point(7, 20);
            this.lstSimple.Name = "lstSimple";
            this.lstSimple.Size = new System.Drawing.Size(134, 121);
            this.lstSimple.TabIndex = 6;
            // 
            // txtZoeken
            // 
            this.txtZoeken.Location = new System.Drawing.Point(121, 211);
            this.txtZoeken.Name = "txtZoeken";
            this.txtZoeken.Size = new System.Drawing.Size(69, 20);
            this.txtZoeken.TabIndex = 7;
            // 
            // txtToevoegen
            // 
            this.txtToevoegen.Location = new System.Drawing.Point(121, 181);
            this.txtToevoegen.Name = "txtToevoegen";
            this.txtToevoegen.Size = new System.Drawing.Size(68, 20);
            this.txtToevoegen.TabIndex = 8;
            // 
            // txtVervangen
            // 
            this.txtVervangen.Location = new System.Drawing.Point(122, 151);
            this.txtVervangen.Name = "txtVervangen";
            this.txtVervangen.Size = new System.Drawing.Size(68, 20);
            this.txtVervangen.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chlstCheckedLB);
            this.groupBox2.Controls.Add(this.txtResultaat);
            this.groupBox2.Location = new System.Drawing.Point(296, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toevoegen en verwijderen";
            // 
            // lblZoeken
            // 
            this.lblZoeken.AutoSize = true;
            this.lblZoeken.Location = new System.Drawing.Point(6, 214);
            this.lblZoeken.Name = "lblZoeken";
            this.lblZoeken.Size = new System.Drawing.Size(35, 13);
            this.lblZoeken.TabIndex = 10;
            this.lblZoeken.Text = "label1";
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(123, 20);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.Size = new System.Drawing.Size(100, 199);
            this.txtResultaat.TabIndex = 1;
            // 
            // chlstCheckedLB
            // 
            this.chlstCheckedLB.FormattingEnabled = true;
            this.chlstCheckedLB.Location = new System.Drawing.Point(7, 20);
            this.chlstCheckedLB.Name = "chlstCheckedLB";
            this.chlstCheckedLB.Size = new System.Drawing.Size(110, 199);
            this.chlstCheckedLB.TabIndex = 2;
            this.chlstCheckedLB.SelectedIndexChanged += new System.EventHandler(this.chlstCheckedLB_SelectedIndexChanged);
            // 
            // FrmListBoxTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListBoxTwo";
            this.Text = "frmListBoxTwo";
            this.Load += new System.EventHandler(this.FrmListBoxTwo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSorteren;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnVervangen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblZoeken;
        private System.Windows.Forms.TextBox txtVervangen;
        private System.Windows.Forms.TextBox txtToevoegen;
        private System.Windows.Forms.TextBox txtZoeken;
        private System.Windows.Forms.ListBox lstSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chlstCheckedLB;
        private System.Windows.Forms.TextBox txtResultaat;
    }
}