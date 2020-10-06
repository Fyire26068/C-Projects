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
            this.label1 = new System.Windows.Forms.Label();
            this.lossLbl = new System.Windows.Forms.Label();
            this.theNumLbl = new System.Windows.Forms.Label();
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
            this.guessSpn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.guessSpn.Name = "guessSpn";
            this.guessSpn.Size = new System.Drawing.Size(115, 86);
            this.guessSpn.TabIndex = 1;
            this.guessSpn.Value = new decimal(new int[] {
            10,
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.theNumLbl);
            this.Controls.Add(this.lossLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.lowerLbl);
            this.Controls.Add(this.highLbl);
            this.Controls.Add(this.guessSpn);
            this.Controls.Add(this.guessBttn);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lossLbl;
        private System.Windows.Forms.Label theNumLbl;
    }
}

