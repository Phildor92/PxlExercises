namespace CircleCalc
{
    partial class FrmOmzetWoord
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.txtNaamOmzet = new System.Windows.Forms.TextBox();
            this.btnOmzet1 = new System.Windows.Forms.Button();
            this.btnOmzet2 = new System.Windows.Forms.Button();
            this.btnAltOmzet1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef de naam in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultaat";
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(104, 10);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(100, 20);
            this.txtInvoer.TabIndex = 2;
            // 
            // txtNaamOmzet
            // 
            this.txtNaamOmzet.Location = new System.Drawing.Point(104, 49);
            this.txtNaamOmzet.Name = "txtNaamOmzet";
            this.txtNaamOmzet.ReadOnly = true;
            this.txtNaamOmzet.Size = new System.Drawing.Size(100, 20);
            this.txtNaamOmzet.TabIndex = 3;
            // 
            // btnOmzet1
            // 
            this.btnOmzet1.Location = new System.Drawing.Point(70, 111);
            this.btnOmzet1.Name = "btnOmzet1";
            this.btnOmzet1.Size = new System.Drawing.Size(116, 77);
            this.btnOmzet1.TabIndex = 4;
            this.btnOmzet1.Text = "Naam omzetten - steeds beginned met hoofdletter, rest kleine letter behalve na ee" +
    "n blanco";
            this.btnOmzet1.UseVisualStyleBackColor = true;
            this.btnOmzet1.Click += new System.EventHandler(this.btnOmzet1_Click);
            // 
            // btnOmzet2
            // 
            this.btnOmzet2.Location = new System.Drawing.Point(270, 111);
            this.btnOmzet2.Name = "btnOmzet2";
            this.btnOmzet2.Size = new System.Drawing.Size(104, 51);
            this.btnOmzet2.TabIndex = 5;
            this.btnOmzet2.Text = "Naam omzetten - voor sortering";
            this.btnOmzet2.UseVisualStyleBackColor = true;
            this.btnOmzet2.Click += new System.EventHandler(this.btnOmzet2_Click);
            // 
            // btnAltOmzet1
            // 
            this.btnAltOmzet1.Location = new System.Drawing.Point(70, 204);
            this.btnAltOmzet1.Name = "btnAltOmzet1";
            this.btnAltOmzet1.Size = new System.Drawing.Size(75, 23);
            this.btnAltOmzet1.TabIndex = 6;
            this.btnAltOmzet1.Text = "Alternative";
            this.btnAltOmzet1.UseVisualStyleBackColor = true;
            this.btnAltOmzet1.Click += new System.EventHandler(this.btnAltOmzet1_Click);
            // 
            // FrmOmzetWoord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 262);
            this.Controls.Add(this.btnAltOmzet1);
            this.Controls.Add(this.btnOmzet2);
            this.Controls.Add(this.btnOmzet1);
            this.Controls.Add(this.txtNaamOmzet);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOmzetWoord";
            this.Text = "FrmOmzetWoord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.TextBox txtNaamOmzet;
        private System.Windows.Forms.Button btnOmzet1;
        private System.Windows.Forms.Button btnOmzet2;
        private System.Windows.Forms.Button btnAltOmzet1;
    }
}