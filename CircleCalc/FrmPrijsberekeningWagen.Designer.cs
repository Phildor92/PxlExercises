namespace CircleCalc
{
    partial class FrmPrijsberekeningWagen
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
            this.lstModel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radHybride = new System.Windows.Forms.RadioButton();
            this.radDiesel = new System.Windows.Forms.RadioButton();
            this.radBenzine = new System.Windows.Forms.RadioButton();
            this.chkMetaalKleur = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAantalJaren = new System.Windows.Forms.TextBox();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.picAfbeelding = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtBerekeningenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actiesAchtergrondkleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.willekeurigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTijd = new System.Windows.Forms.Label();
            this.tijdTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAfbeelding)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstModel
            // 
            this.lstModel.FormattingEnabled = true;
            this.lstModel.Location = new System.Drawing.Point(96, 38);
            this.lstModel.Name = "lstModel";
            this.lstModel.Size = new System.Drawing.Size(120, 95);
            this.lstModel.TabIndex = 0;
            this.lstModel.SelectedIndexChanged += new System.EventHandler(this.lstModel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radHybride);
            this.groupBox1.Controls.Add(this.radDiesel);
            this.groupBox1.Controls.Add(this.radBenzine);
            this.groupBox1.Location = new System.Drawing.Point(16, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motortype";
            // 
            // radHybride
            // 
            this.radHybride.AutoSize = true;
            this.radHybride.Location = new System.Drawing.Point(6, 65);
            this.radHybride.Name = "radHybride";
            this.radHybride.Size = new System.Drawing.Size(61, 17);
            this.radHybride.TabIndex = 2;
            this.radHybride.TabStop = true;
            this.radHybride.Text = "Hybride";
            this.radHybride.UseVisualStyleBackColor = true;
            // 
            // radDiesel
            // 
            this.radDiesel.AutoSize = true;
            this.radDiesel.Location = new System.Drawing.Point(6, 42);
            this.radDiesel.Name = "radDiesel";
            this.radDiesel.Size = new System.Drawing.Size(54, 17);
            this.radDiesel.TabIndex = 1;
            this.radDiesel.TabStop = true;
            this.radDiesel.Text = "Diesel";
            this.radDiesel.UseVisualStyleBackColor = true;
            // 
            // radBenzine
            // 
            this.radBenzine.AutoSize = true;
            this.radBenzine.Location = new System.Drawing.Point(6, 19);
            this.radBenzine.Name = "radBenzine";
            this.radBenzine.Size = new System.Drawing.Size(63, 17);
            this.radBenzine.TabIndex = 0;
            this.radBenzine.TabStop = true;
            this.radBenzine.Text = "Benzine";
            this.radBenzine.UseVisualStyleBackColor = true;
            // 
            // chkMetaalKleur
            // 
            this.chkMetaalKleur.AutoSize = true;
            this.chkMetaalKleur.Location = new System.Drawing.Point(16, 239);
            this.chkMetaalKleur.Name = "chkMetaalKleur";
            this.chkMetaalKleur.Size = new System.Drawing.Size(87, 17);
            this.chkMetaalKleur.TabIndex = 3;
            this.chkMetaalKleur.Text = "Metaalkleur?";
            this.chkMetaalKleur.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "aantal jaren afbetaling";
            // 
            // txtAantalJaren
            // 
            this.txtAantalJaren.Location = new System.Drawing.Point(130, 256);
            this.txtAantalJaren.Name = "txtAantalJaren";
            this.txtAantalJaren.Size = new System.Drawing.Size(100, 20);
            this.txtAantalJaren.TabIndex = 5;
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(13, 282);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultaat.Size = new System.Drawing.Size(552, 114);
            this.txtResultaat.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(490, 36);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Berekenen";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(490, 65);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(75, 23);
            this.btnNieuw.TabIndex = 8;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // picAfbeelding
            // 
            this.picAfbeelding.Image = global::CircleCalc.Properties.Resources.wagen0;
            this.picAfbeelding.Location = new System.Drawing.Point(247, 38);
            this.picAfbeelding.Name = "picAfbeelding";
            this.picAfbeelding.Size = new System.Drawing.Size(216, 183);
            this.picAfbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAfbeelding.TabIndex = 9;
            this.picAfbeelding.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem,
            this.overzichtBerekeningenToolStripMenuItem,
            this.actiesAchtergrondkleurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // overzichtBerekeningenToolStripMenuItem
            // 
            this.overzichtBerekeningenToolStripMenuItem.Name = "overzichtBerekeningenToolStripMenuItem";
            this.overzichtBerekeningenToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.overzichtBerekeningenToolStripMenuItem.Text = "Overzicht berekeningen";
            this.overzichtBerekeningenToolStripMenuItem.Click += new System.EventHandler(this.overzichtBerekeningenToolStripMenuItem_Click);
            // 
            // actiesAchtergrondkleurToolStripMenuItem
            // 
            this.actiesAchtergrondkleurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roodToolStripMenuItem,
            this.willekeurigToolStripMenuItem});
            this.actiesAchtergrondkleurToolStripMenuItem.Name = "actiesAchtergrondkleurToolStripMenuItem";
            this.actiesAchtergrondkleurToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.actiesAchtergrondkleurToolStripMenuItem.Text = "Acties achtergrondkleur";
            // 
            // roodToolStripMenuItem
            // 
            this.roodToolStripMenuItem.Name = "roodToolStripMenuItem";
            this.roodToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.roodToolStripMenuItem.Text = "Achtergrondkleur wisselen";
            this.roodToolStripMenuItem.Click += new System.EventHandler(this.roodToolStripMenuItem_Click);
            // 
            // willekeurigToolStripMenuItem
            // 
            this.willekeurigToolStripMenuItem.Name = "willekeurigToolStripMenuItem";
            this.willekeurigToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.willekeurigToolStripMenuItem.Text = "Willekeurig";
            this.willekeurigToolStripMenuItem.Click += new System.EventHandler(this.willekeurigToolStripMenuItem_Click);
            // 
            // lblTijd
            // 
            this.lblTijd.AutoSize = true;
            this.lblTijd.Location = new System.Drawing.Point(428, 259);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(35, 13);
            this.lblTijd.TabIndex = 11;
            this.lblTijd.Text = "label3";
            // 
            // tijdTimer
            // 
            this.tijdTimer.Tick += new System.EventHandler(this.tijdTimer_Tick);
            // 
            // FrmPrijsberekeningWagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 408);
            this.Controls.Add(this.lblTijd);
            this.Controls.Add(this.picAfbeelding);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.txtAantalJaren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkMetaalKleur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstModel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrijsberekeningWagen";
            this.Text = "FrmPrijsberekeningWagen";
            this.Load += new System.EventHandler(this.FrmPrijsberekeningWagen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAfbeelding)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radHybride;
        private System.Windows.Forms.RadioButton radDiesel;
        private System.Windows.Forms.RadioButton radBenzine;
        private System.Windows.Forms.CheckBox chkMetaalKleur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAantalJaren;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.PictureBox picAfbeelding;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtBerekeningenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actiesAchtergrondkleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem willekeurigToolStripMenuItem;
        private System.Windows.Forms.Label lblTijd;
        private System.Windows.Forms.Timer tijdTimer;
    }
}