namespace CircleCalc
{
    partial class FrmTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimer));
            this.label1 = new System.Windows.Forms.Label();
            this.intervalTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tellerTxt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.wisBtn = new System.Windows.Forms.Button();
            this.sluitBtn = new System.Windows.Forms.Button();
            this.aftellenTmr = new System.Windows.Forms.Timer(this.components);
            this.eindeBtn = new System.Windows.Forms.Button();
            this.afbeeldingPic = new System.Windows.Forms.PictureBox();
            this.afbeeldingTmr = new System.Windows.Forms.Timer(this.components);
            this.timeTmr = new System.Windows.Forms.Timer(this.components);
            this.tijdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.afbeeldingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef het interval:";
            // 
            // intervalTxt
            // 
            this.intervalTxt.Location = new System.Drawing.Point(144, 23);
            this.intervalTxt.Name = "intervalTxt";
            this.intervalTxt.Size = new System.Drawing.Size(46, 20);
            this.intervalTxt.TabIndex = 1;
            this.intervalTxt.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(in milliseconden)";
            // 
            // tellerTxt
            // 
            this.tellerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellerTxt.Location = new System.Drawing.Point(54, 68);
            this.tellerTxt.Name = "tellerTxt";
            this.tellerTxt.Size = new System.Drawing.Size(136, 80);
            this.tellerTxt.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(261, 34);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Starten";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // wisBtn
            // 
            this.wisBtn.Location = new System.Drawing.Point(261, 94);
            this.wisBtn.Name = "wisBtn";
            this.wisBtn.Size = new System.Drawing.Size(75, 23);
            this.wisBtn.TabIndex = 5;
            this.wisBtn.Text = "Wissen";
            this.wisBtn.UseVisualStyleBackColor = true;
            this.wisBtn.Click += new System.EventHandler(this.wisBtn_Click);
            // 
            // sluitBtn
            // 
            this.sluitBtn.Location = new System.Drawing.Point(261, 125);
            this.sluitBtn.Name = "sluitBtn";
            this.sluitBtn.Size = new System.Drawing.Size(75, 23);
            this.sluitBtn.TabIndex = 6;
            this.sluitBtn.Text = "Sluiten";
            this.sluitBtn.UseVisualStyleBackColor = true;
            this.sluitBtn.Click += new System.EventHandler(this.sluitBtn_Click);
            // 
            // aftellenTmr
            // 
            this.aftellenTmr.Tick += new System.EventHandler(this.aftellenTmr_Tick);
            // 
            // eindeBtn
            // 
            this.eindeBtn.Location = new System.Drawing.Point(261, 64);
            this.eindeBtn.Name = "eindeBtn";
            this.eindeBtn.Size = new System.Drawing.Size(75, 23);
            this.eindeBtn.TabIndex = 7;
            this.eindeBtn.Text = "Stoppen";
            this.eindeBtn.UseVisualStyleBackColor = true;
            this.eindeBtn.Click += new System.EventHandler(this.eindeBtn_Click);
            // 
            // afbeeldingPic
            // 
            this.afbeeldingPic.Image = ((System.Drawing.Image)(resources.GetObject("afbeeldingPic.Image")));
            this.afbeeldingPic.Location = new System.Drawing.Point(12, 186);
            this.afbeeldingPic.Name = "afbeeldingPic";
            this.afbeeldingPic.Size = new System.Drawing.Size(182, 182);
            this.afbeeldingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.afbeeldingPic.TabIndex = 8;
            this.afbeeldingPic.TabStop = false;
            // 
            // afbeeldingTmr
            // 
            this.afbeeldingTmr.Interval = 5;
            this.afbeeldingTmr.Tick += new System.EventHandler(this.afbeeldingTmr_Tick);
            // 
            // timeTmr
            // 
            this.timeTmr.Enabled = true;
            this.timeTmr.Tick += new System.EventHandler(this.timeTmr_Tick);
            // 
            // tijdLbl
            // 
            this.tijdLbl.Location = new System.Drawing.Point(286, 214);
            this.tijdLbl.Name = "tijdLbl";
            this.tijdLbl.Size = new System.Drawing.Size(78, 17);
            this.tijdLbl.TabIndex = 10;
            this.tijdLbl.Text = "00:00:00";
            // 
            // FrmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 380);
            this.Controls.Add(this.tijdLbl);
            this.Controls.Add(this.afbeeldingPic);
            this.Controls.Add(this.eindeBtn);
            this.Controls.Add(this.sluitBtn);
            this.Controls.Add(this.wisBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.tellerTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervalTxt);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimer";
            this.Text = "FrmTimer";
            this.Load += new System.EventHandler(this.FrmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afbeeldingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tellerTxt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button wisBtn;
        private System.Windows.Forms.Button sluitBtn;
        private System.Windows.Forms.Timer aftellenTmr;
        private System.Windows.Forms.Button eindeBtn;
        private System.Windows.Forms.PictureBox afbeeldingPic;
        private System.Windows.Forms.Timer afbeeldingTmr;
        private System.Windows.Forms.Timer timeTmr;
        private System.Windows.Forms.Label tijdLbl;
    }
}