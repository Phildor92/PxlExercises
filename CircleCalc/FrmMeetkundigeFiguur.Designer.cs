namespace CircleCalc
{
    partial class FrmMeetkundigeFiguur
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
            this.btnRuit = new System.Windows.Forms.Button();
            this.btnVierkant = new System.Windows.Forms.Button();
            this.btnDriehoek = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnOpbouw = new System.Windows.Forms.Button();
            this.volVierkant = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.txtGrootte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRuit
            // 
            this.btnRuit.Location = new System.Drawing.Point(253, 12);
            this.btnRuit.Name = "btnRuit";
            this.btnRuit.Size = new System.Drawing.Size(88, 23);
            this.btnRuit.TabIndex = 0;
            this.btnRuit.Text = "Ruit";
            this.btnRuit.UseVisualStyleBackColor = true;
            this.btnRuit.Click += new System.EventHandler(this.btnRuit_Click);
            // 
            // btnVierkant
            // 
            this.btnVierkant.Location = new System.Drawing.Point(253, 42);
            this.btnVierkant.Name = "btnVierkant";
            this.btnVierkant.Size = new System.Drawing.Size(88, 23);
            this.btnVierkant.TabIndex = 1;
            this.btnVierkant.Text = "Rand vierkant";
            this.btnVierkant.UseVisualStyleBackColor = true;
            this.btnVierkant.Click += new System.EventHandler(this.btnVierkant_Click);
            // 
            // btnDriehoek
            // 
            this.btnDriehoek.Location = new System.Drawing.Point(253, 72);
            this.btnDriehoek.Name = "btnDriehoek";
            this.btnDriehoek.Size = new System.Drawing.Size(88, 23);
            this.btnDriehoek.TabIndex = 2;
            this.btnDriehoek.Text = "Driehoek";
            this.btnDriehoek.UseVisualStyleBackColor = true;
            this.btnDriehoek.Click += new System.EventHandler(this.btnDriehoek_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnOpbouw
            // 
            this.btnOpbouw.Location = new System.Drawing.Point(347, 42);
            this.btnOpbouw.Name = "btnOpbouw";
            this.btnOpbouw.Size = new System.Drawing.Size(100, 23);
            this.btnOpbouw.TabIndex = 4;
            this.btnOpbouw.Text = "Opbouw Vierkant";
            this.btnOpbouw.UseVisualStyleBackColor = true;
            this.btnOpbouw.Click += new System.EventHandler(this.btnOpbouw_Click);
            // 
            // volVierkant
            // 
            this.volVierkant.Location = new System.Drawing.Point(347, 12);
            this.volVierkant.Name = "volVierkant";
            this.volVierkant.Size = new System.Drawing.Size(100, 23);
            this.volVierkant.TabIndex = 3;
            this.volVierkant.Text = "Vol vierkant";
            this.volVierkant.UseVisualStyleBackColor = true;
            this.volVierkant.Click += new System.EventHandler(this.volVierkant_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaat.Location = new System.Drawing.Point(12, 101);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(491, 304);
            this.txtResultaat.TabIndex = 6;
            // 
            // txtGrootte
            // 
            this.txtGrootte.Location = new System.Drawing.Point(12, 28);
            this.txtGrootte.Name = "txtGrootte";
            this.txtGrootte.Size = new System.Drawing.Size(100, 20);
            this.txtGrootte.TabIndex = 7;
            this.txtGrootte.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Grootte figuur";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMeetkundigeFiguur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrootte);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnOpbouw);
            this.Controls.Add(this.volVierkant);
            this.Controls.Add(this.btnDriehoek);
            this.Controls.Add(this.btnVierkant);
            this.Controls.Add(this.btnRuit);
            this.Name = "FrmMeetkundigeFiguur";
            this.Text = "FrmMeetkundigeFiguur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRuit;
        private System.Windows.Forms.Button btnVierkant;
        private System.Windows.Forms.Button btnDriehoek;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnOpbouw;
        private System.Windows.Forms.Button volVierkant;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.TextBox txtGrootte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}