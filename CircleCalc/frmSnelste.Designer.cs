namespace CircleCalc
{
    partial class FrmSnelste
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totTimeTxt = new System.Windows.Forms.TextBox();
            this.athlNameTxt = new System.Windows.Forms.TextBox();
            this.newEntryBtn = new System.Windows.Forms.Button();
            this.fastestAthlBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeAppBtn = new System.Windows.Forms.Button();
            this.fastRunnerTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totTimeTxt);
            this.panel1.Controls.Add(this.athlNameTxt);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 99);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totaal aantal seconden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam atleet";
            // 
            // totTimeTxt
            // 
            this.totTimeTxt.Location = new System.Drawing.Point(144, 61);
            this.totTimeTxt.Name = "totTimeTxt";
            this.totTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.totTimeTxt.TabIndex = 1;
            // 
            // athlNameTxt
            // 
            this.athlNameTxt.Location = new System.Drawing.Point(144, 20);
            this.athlNameTxt.Name = "athlNameTxt";
            this.athlNameTxt.Size = new System.Drawing.Size(100, 20);
            this.athlNameTxt.TabIndex = 0;
            // 
            // newEntryBtn
            // 
            this.newEntryBtn.Location = new System.Drawing.Point(211, 149);
            this.newEntryBtn.Name = "newEntryBtn";
            this.newEntryBtn.Size = new System.Drawing.Size(99, 23);
            this.newEntryBtn.TabIndex = 2;
            this.newEntryBtn.Text = "Nieuwe ingave";
            this.newEntryBtn.UseVisualStyleBackColor = true;
            this.newEntryBtn.Click += new System.EventHandler(this.newEntryBtn_Click);
            // 
            // fastestAthlBtn
            // 
            this.fastestAthlBtn.Location = new System.Drawing.Point(211, 178);
            this.fastestAthlBtn.Name = "fastestAthlBtn";
            this.fastestAthlBtn.Size = new System.Drawing.Size(99, 23);
            this.fastestAthlBtn.TabIndex = 3;
            this.fastestAthlBtn.Text = "Snelste atleet";
            this.fastestAthlBtn.UseVisualStyleBackColor = true;
            this.fastestAthlBtn.Click += new System.EventHandler(this.fastestAthlBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(211, 207);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Wissen";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.Location = new System.Drawing.Point(211, 236);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.Size = new System.Drawing.Size(100, 23);
            this.closeAppBtn.TabIndex = 5;
            this.closeAppBtn.Text = "Sluiten";
            this.closeAppBtn.UseVisualStyleBackColor = true;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // fastRunnerTxt
            // 
            this.fastRunnerTxt.AcceptsReturn = true;
            this.fastRunnerTxt.Location = new System.Drawing.Point(13, 119);
            this.fastRunnerTxt.Multiline = true;
            this.fastRunnerTxt.Name = "fastRunnerTxt";
            this.fastRunnerTxt.ReadOnly = true;
            this.fastRunnerTxt.Size = new System.Drawing.Size(192, 177);
            this.fastRunnerTxt.TabIndex = 6;
            // 
            // FrmSnelste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 308);
            this.Controls.Add(this.fastRunnerTxt);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.fastestAthlBtn);
            this.Controls.Add(this.newEntryBtn);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSnelste";
            this.Text = "Snelste Atleet";
            this.Load += new System.EventHandler(this.FrmSnelste_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totTimeTxt;
        private System.Windows.Forms.TextBox athlNameTxt;
        private System.Windows.Forms.Button newEntryBtn;
        private System.Windows.Forms.Button fastestAthlBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button closeAppBtn;
        private System.Windows.Forms.TextBox fastRunnerTxt;
    }
}