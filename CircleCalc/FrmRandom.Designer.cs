﻿namespace CircleCalc
{
    partial class FrmRandom
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
            this.randTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNieuweWaarde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randTxt
            // 
            this.randTxt.Location = new System.Drawing.Point(148, 55);
            this.randTxt.Name = "randTxt";
            this.randTxt.Size = new System.Drawing.Size(100, 20);
            this.randTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gegenereerde Waarde";
            // 
            // btnNieuweWaarde
            // 
            this.btnNieuweWaarde.Location = new System.Drawing.Point(281, 55);
            this.btnNieuweWaarde.Name = "btnNieuweWaarde";
            this.btnNieuweWaarde.Size = new System.Drawing.Size(112, 23);
            this.btnNieuweWaarde.TabIndex = 2;
            this.btnNieuweWaarde.Text = "Nieuwe Waarde";
            this.btnNieuweWaarde.UseVisualStyleBackColor = true;
            this.btnNieuweWaarde.Click += new System.EventHandler(this.btnNieuweWaarde_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 348);
            this.Controls.Add(this.btnNieuweWaarde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randTxt);
            this.Name = "FrmRandom";
            this.Text = "FrmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox randTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNieuweWaarde;
    }
}