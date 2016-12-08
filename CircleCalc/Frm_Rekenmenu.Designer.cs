namespace CircleCalc
{
    partial class Frm_Rekenmenu
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
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.lblBewerking = new System.Windows.Forms.Label();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.lblAantalJuist = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aardOefeningenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aftrekkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vermenigvuldigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweReeksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eindeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControle = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.btnResultaat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGetal1
            // 
            this.txtGetal1.Enabled = false;
            this.txtGetal1.Location = new System.Drawing.Point(12, 48);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.ReadOnly = true;
            this.txtGetal1.Size = new System.Drawing.Size(56, 20);
            this.txtGetal1.TabIndex = 0;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(93, 48);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.ReadOnly = true;
            this.txtGetal2.Size = new System.Drawing.Size(51, 20);
            this.txtGetal2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(169, 48);
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(61, 20);
            this.txtResultaat.TabIndex = 4;
            // 
            // lblBewerking
            // 
            this.lblBewerking.AutoSize = true;
            this.lblBewerking.Location = new System.Drawing.Point(74, 51);
            this.lblBewerking.Name = "lblBewerking";
            this.lblBewerking.Size = new System.Drawing.Size(13, 13);
            this.lblBewerking.TabIndex = 5;
            this.lblBewerking.Text = "+";
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(254, 51);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(33, 13);
            this.lblResultaat.TabIndex = 6;
            this.lblResultaat.Text = "Goed";
            this.lblResultaat.Visible = false;
            // 
            // lblAantalJuist
            // 
            this.lblAantalJuist.AutoSize = true;
            this.lblAantalJuist.Location = new System.Drawing.Point(90, 129);
            this.lblAantalJuist.Name = "lblAantalJuist";
            this.lblAantalJuist.Size = new System.Drawing.Size(35, 13);
            this.lblAantalJuist.TabIndex = 7;
            this.lblAantalJuist.Text = "label3";
            this.lblAantalJuist.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.aardOefeningenToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuweReeksToolStripMenuItem,
            this.eindeToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // aardOefeningenToolStripMenuItem
            // 
            this.aardOefeningenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optellenToolStripMenuItem,
            this.aftrekkenToolStripMenuItem,
            this.vermenigvuldigenToolStripMenuItem});
            this.aardOefeningenToolStripMenuItem.Name = "aardOefeningenToolStripMenuItem";
            this.aardOefeningenToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.aardOefeningenToolStripMenuItem.Text = "Aard oefeningen";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // optellenToolStripMenuItem
            // 
            this.optellenToolStripMenuItem.Checked = true;
            this.optellenToolStripMenuItem.CheckOnClick = true;
            this.optellenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optellenToolStripMenuItem.Name = "optellenToolStripMenuItem";
            this.optellenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.optellenToolStripMenuItem.Text = "Optellen";
            this.optellenToolStripMenuItem.Click += new System.EventHandler(this.optellenToolStripMenuItem_Click);
            // 
            // aftrekkenToolStripMenuItem
            // 
            this.aftrekkenToolStripMenuItem.CheckOnClick = true;
            this.aftrekkenToolStripMenuItem.Name = "aftrekkenToolStripMenuItem";
            this.aftrekkenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aftrekkenToolStripMenuItem.Text = "Aftrekken";
            this.aftrekkenToolStripMenuItem.Click += new System.EventHandler(this.aftrekkenToolStripMenuItem_Click);
            // 
            // vermenigvuldigenToolStripMenuItem
            // 
            this.vermenigvuldigenToolStripMenuItem.CheckOnClick = true;
            this.vermenigvuldigenToolStripMenuItem.Name = "vermenigvuldigenToolStripMenuItem";
            this.vermenigvuldigenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.vermenigvuldigenToolStripMenuItem.Text = "Vermenigvuldigen";
            this.vermenigvuldigenToolStripMenuItem.Click += new System.EventHandler(this.vermenigvuldigenToolStripMenuItem_Click);
            // 
            // nieuweReeksToolStripMenuItem
            // 
            this.nieuweReeksToolStripMenuItem.Enabled = false;
            this.nieuweReeksToolStripMenuItem.Name = "nieuweReeksToolStripMenuItem";
            this.nieuweReeksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nieuweReeksToolStripMenuItem.Text = "Nieuwe reeks";
            this.nieuweReeksToolStripMenuItem.Click += new System.EventHandler(this.nieuweReeksToolStripMenuItem_Click);
            // 
            // eindeToolStripMenuItem
            // 
            this.eindeToolStripMenuItem.Name = "eindeToolStripMenuItem";
            this.eindeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eindeToolStripMenuItem.Text = "Einde";
            this.eindeToolStripMenuItem.Click += new System.EventHandler(this.eindeToolStripMenuItem_Click);
            // 
            // btnControle
            // 
            this.btnControle.Location = new System.Drawing.Point(334, 38);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(75, 23);
            this.btnControle.TabIndex = 9;
            this.btnControle.Text = "Controle";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(334, 68);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(75, 23);
            this.btnVolgende.TabIndex = 10;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // btnResultaat
            // 
            this.btnResultaat.Location = new System.Drawing.Point(334, 98);
            this.btnResultaat.Name = "btnResultaat";
            this.btnResultaat.Size = new System.Drawing.Size(75, 23);
            this.btnResultaat.TabIndex = 11;
            this.btnResultaat.Text = "Resultaat";
            this.btnResultaat.UseVisualStyleBackColor = true;
            this.btnResultaat.Click += new System.EventHandler(this.btnResultaat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Rekenmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 267);
            this.Controls.Add(this.btnResultaat);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.btnControle);
            this.Controls.Add(this.lblAantalJuist);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.lblBewerking);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Rekenmenu";
            this.Text = "Frm_Rekenmenu";
            this.Load += new System.EventHandler(this.Frm_Rekenmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Label lblBewerking;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.Label lblAantalJuist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuweReeksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eindeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aardOefeningenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aftrekkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vermenigvuldigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Button btnResultaat;
        private System.Windows.Forms.Timer timer1;
    }
}