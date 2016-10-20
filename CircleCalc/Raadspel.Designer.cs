namespace CircleCalc
{
    partial class Raadspel
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
            this.label1 = new System.Windows.Forms.Label();
            this.guessNumTxt = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.numGuesses = new System.Windows.Forms.TextBox();
            this.eval = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef een getal tussen 1 en 100: ";
            // 
            // guessNumTxt
            // 
            this.guessNumTxt.Location = new System.Drawing.Point(181, 10);
            this.guessNumTxt.Name = "guessNumTxt";
            this.guessNumTxt.Size = new System.Drawing.Size(26, 20);
            this.guessNumTxt.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(16, 65);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(191, 20);
            this.result.TabIndex = 2;
            // 
            // numGuesses
            // 
            this.numGuesses.Location = new System.Drawing.Point(16, 92);
            this.numGuesses.Name = "numGuesses";
            this.numGuesses.ReadOnly = true;
            this.numGuesses.Size = new System.Drawing.Size(191, 20);
            this.numGuesses.TabIndex = 3;
            // 
            // eval
            // 
            this.eval.Location = new System.Drawing.Point(241, 26);
            this.eval.Name = "eval";
            this.eval.Size = new System.Drawing.Size(75, 23);
            this.eval.TabIndex = 4;
            this.eval.Text = "Evalueer";
            this.eval.UseVisualStyleBackColor = true;
            this.eval.Click += new System.EventHandler(this.eval_Click);
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(241, 56);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 23);
            this.newGame.TabIndex = 5;
            this.newGame.Text = "Nieuw Spel";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(241, 85);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(75, 23);
            this.End.TabIndex = 6;
            this.End.Text = "Einde";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Raadspel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 143);
            this.Controls.Add(this.End);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.eval);
            this.Controls.Add(this.numGuesses);
            this.Controls.Add(this.result);
            this.Controls.Add(this.guessNumTxt);
            this.Controls.Add(this.label1);
            this.Name = "Raadspel";
            this.Text = "Raadspel";
            this.Load += new System.EventHandler(this.Raadspel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guessNumTxt;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox numGuesses;
        private System.Windows.Forms.Button eval;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Timer timer1;
    }
}