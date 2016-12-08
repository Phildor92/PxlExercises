namespace CircleCalc
{
    partial class FrmListBox
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
            this.lstGemeente = new System.Windows.Forms.ListBox();
            this.btnToon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.lstSporttak = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstGemeente
            // 
            this.lstGemeente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGemeente.FormattingEnabled = true;
            this.lstGemeente.ItemHeight = 24;
            this.lstGemeente.Items.AddRange(new object[] {
            "Aalst",
            "Oostende",
            "Luik",
            "Diest",
            "Aarschot",
            "Bergen"});
            this.lstGemeente.Location = new System.Drawing.Point(117, 33);
            this.lstGemeente.Name = "lstGemeente";
            this.lstGemeente.Size = new System.Drawing.Size(120, 28);
            this.lstGemeente.TabIndex = 0;
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(16, 88);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(100, 23);
            this.btnToon.TabIndex = 1;
            this.btnToon.Text = "Toon gegevens";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gemeente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sporttak";
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(12, 161);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(259, 114);
            this.txtResultaat.TabIndex = 4;
            // 
            // lstSporttak
            // 
            this.lstSporttak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSporttak.FormattingEnabled = true;
            this.lstSporttak.ItemHeight = 24;
            this.lstSporttak.Items.AddRange(new object[] {
            "zwemmen",
            "atletiek",
            "voetbal",
            "paardrijden",
            "kayak",
            "turnen"});
            this.lstSporttak.Location = new System.Drawing.Point(330, 33);
            this.lstSporttak.Name = "lstSporttak";
            this.lstSporttak.Size = new System.Drawing.Size(120, 28);
            this.lstSporttak.TabIndex = 5;
            // 
            // FrmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 287);
            this.Controls.Add(this.lstSporttak);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.lstGemeente);
            this.Name = "FrmListBox";
            this.Text = "FrmListBox";
            this.Load += new System.EventHandler(this.FrmListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGemeente;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.ListBox lstSporttak;
    }
}