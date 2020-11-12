namespace Guess_my_number
{
    partial class Form1
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
            this.guessBttn = new System.Windows.Forms.Button();
            this.guessSpn = new System.Windows.Forms.NumericUpDown();
            this.highLbl = new System.Windows.Forms.Label();
            this.lowerLbl = new System.Windows.Forms.Label();
            this.winLbl = new System.Windows.Forms.Label();
            this.lossLbl = new System.Windows.Forms.Label();
            this.theNumLbl = new System.Windows.Forms.Label();
            this.guessLbl = new System.Windows.Forms.Label();
            this.guessAmLbl = new System.Windows.Forms.Label();
            this.easyRB = new System.Windows.Forms.RadioButton();
            this.mediumRB = new System.Windows.Forms.RadioButton();
            this.hardRB = new System.Windows.Forms.RadioButton();
            this.promptLbl = new System.Windows.Forms.Label();
            this.pNumberLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guessSpn)).BeginInit();
            this.SuspendLayout();
            // 
            // guessBttn
            // 
            this.guessBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guessBttn.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBttn.Location = new System.Drawing.Point(549, 186);
            this.guessBttn.Name = "guessBttn";
            this.guessBttn.Size = new System.Drawing.Size(224, 95);
            this.guessBttn.TabIndex = 0;
            this.guessBttn.Text = "GUESS";
            this.guessBttn.UseVisualStyleBackColor = true;
            this.guessBttn.Click += new System.EventHandler(this.guessBttn_Click);
            // 
            // guessSpn
            // 
            this.guessSpn.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessSpn.Location = new System.Drawing.Point(412, 195);
            this.guessSpn.Name = "guessSpn";
            this.guessSpn.Size = new System.Drawing.Size(115, 86);
            this.guessSpn.TabIndex = 1;
            this.guessSpn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guessSpn.ValueChanged += new System.EventHandler(this.guessSpn_ValueChanged);
            // 
            // highLbl
            // 
            this.highLbl.AutoSize = true;
            this.highLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLbl.Location = new System.Drawing.Point(39, 67);
            this.highLbl.Name = "highLbl";
            this.highLbl.Size = new System.Drawing.Size(260, 25);
            this.highLbl.TabIndex = 2;
            this.highLbl.Text = "You need to guess higher";
            this.highLbl.Visible = false;
            this.highLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lowerLbl
            // 
            this.lowerLbl.AutoSize = true;
            this.lowerLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLbl.Location = new System.Drawing.Point(49, 355);
            this.lowerLbl.Name = "lowerLbl";
            this.lowerLbl.Size = new System.Drawing.Size(250, 25);
            this.lowerLbl.TabIndex = 3;
            this.lowerLbl.Text = "You need to guess lower";
            this.lowerLbl.Visible = false;
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLbl.Location = new System.Drawing.Point(39, 228);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(289, 25);
            this.winLbl.TabIndex = 4;
            this.winLbl.Text = "You guessed the Number!";
            this.winLbl.Visible = false;
            // 
            // lossLbl
            // 
            this.lossLbl.AutoSize = true;
            this.lossLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossLbl.Location = new System.Drawing.Point(36, 132);
            this.lossLbl.Name = "lossLbl";
            this.lossLbl.Size = new System.Drawing.Size(543, 25);
            this.lossLbl.TabIndex = 6;
            this.lossLbl.Text = "You did not guess the number. The number was :";
            this.lossLbl.Visible = false;
            // 
            // theNumLbl
            // 
            this.theNumLbl.AutoSize = true;
            this.theNumLbl.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theNumLbl.Location = new System.Drawing.Point(585, 103);
            this.theNumLbl.Name = "theNumLbl";
            this.theNumLbl.Size = new System.Drawing.Size(102, 80);
            this.theNumLbl.TabIndex = 7;
            this.theNumLbl.Text = "00";
            this.theNumLbl.Visible = false;
            this.theNumLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // guessLbl
            // 
            this.guessLbl.AutoSize = true;
            this.guessLbl.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLbl.Location = new System.Drawing.Point(490, 355);
            this.guessLbl.Name = "guessLbl";
            this.guessLbl.Size = new System.Drawing.Size(126, 28);
            this.guessLbl.TabIndex = 8;
            this.guessLbl.Text = "Guesses: ";
            this.guessLbl.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // guessAmLbl
            // 
            this.guessAmLbl.AutoSize = true;
            this.guessAmLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessAmLbl.Location = new System.Drawing.Point(611, 346);
            this.guessAmLbl.Name = "guessAmLbl";
            this.guessAmLbl.Size = new System.Drawing.Size(34, 39);
            this.guessAmLbl.TabIndex = 9;
            this.guessAmLbl.Text = "3";
            // 
            // easyRB
            // 
            this.easyRB.AutoSize = true;
            this.easyRB.Checked = true;
            this.easyRB.Location = new System.Drawing.Point(688, 12);
            this.easyRB.Name = "easyRB";
            this.easyRB.Size = new System.Drawing.Size(48, 17);
            this.easyRB.TabIndex = 10;
            this.easyRB.TabStop = true;
            this.easyRB.Text = "Easy";
            this.easyRB.UseVisualStyleBackColor = true;
            this.easyRB.CheckedChanged += new System.EventHandler(this.easyRB_CheckedChanged);
            // 
            // mediumRB
            // 
            this.mediumRB.AutoSize = true;
            this.mediumRB.Location = new System.Drawing.Point(688, 36);
            this.mediumRB.Name = "mediumRB";
            this.mediumRB.Size = new System.Drawing.Size(62, 17);
            this.mediumRB.TabIndex = 11;
            this.mediumRB.TabStop = true;
            this.mediumRB.Text = "Medium";
            this.mediumRB.UseVisualStyleBackColor = true;
            this.mediumRB.CheckedChanged += new System.EventHandler(this.mediumRB_CheckedChanged);
            // 
            // hardRB
            // 
            this.hardRB.AutoSize = true;
            this.hardRB.Location = new System.Drawing.Point(688, 60);
            this.hardRB.Name = "hardRB";
            this.hardRB.Size = new System.Drawing.Size(48, 17);
            this.hardRB.TabIndex = 12;
            this.hardRB.TabStop = true;
            this.hardRB.Text = "Hard";
            this.hardRB.UseVisualStyleBackColor = true;
            this.hardRB.CheckedChanged += new System.EventHandler(this.hardRB_CheckedChanged);
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLbl.Location = new System.Drawing.Point(174, 301);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(353, 25);
            this.promptLbl.TabIndex = 13;
            this.promptLbl.Text = "I\'m thinking of a number between:";
            this.promptLbl.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // pNumberLbl
            // 
            this.pNumberLbl.AutoSize = true;
            this.pNumberLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNumberLbl.Location = new System.Drawing.Point(544, 301);
            this.pNumberLbl.Name = "pNumberLbl";
            this.pNumberLbl.Size = new System.Drawing.Size(73, 25);
            this.pNumberLbl.TabIndex = 14;
            this.pNumberLbl.Text = "1 - 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pNumberLbl);
            this.Controls.Add(this.promptLbl);
            this.Controls.Add(this.hardRB);
            this.Controls.Add(this.mediumRB);
            this.Controls.Add(this.easyRB);
            this.Controls.Add(this.guessAmLbl);
            this.Controls.Add(this.guessLbl);
            this.Controls.Add(this.theNumLbl);
            this.Controls.Add(this.lossLbl);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.lowerLbl);
            this.Controls.Add(this.highLbl);
            this.Controls.Add(this.guessSpn);
            this.Controls.Add(this.guessBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.guessSpn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessBttn;
        private System.Windows.Forms.NumericUpDown guessSpn;
        private System.Windows.Forms.Label highLbl;
        private System.Windows.Forms.Label lowerLbl;
        private System.Windows.Forms.Label winLbl;
        private System.Windows.Forms.Label lossLbl;
        private System.Windows.Forms.Label theNumLbl;
        private System.Windows.Forms.Label guessLbl;
        private System.Windows.Forms.Label guessAmLbl;
        private System.Windows.Forms.RadioButton easyRB;
        private System.Windows.Forms.RadioButton mediumRB;
        private System.Windows.Forms.RadioButton hardRB;
        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.Label pNumberLbl;
    }
}

