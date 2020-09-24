namespace Fig_Clicker
{
    partial class FigClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigClicker));
            this.figAmountSpin = new System.Windows.Forms.NumericUpDown();
            this.figClickerBttn = new System.Windows.Forms.Button();
            this.figAmountLbl = new System.Windows.Forms.Label();
            this.noUpDownLbl = new System.Windows.Forms.Label();
            this.unlock1PrBar = new System.Windows.Forms.ProgressBar();
            this.autoClickerLbl = new System.Windows.Forms.Label();
            this.autoClickerBuyBttn = new System.Windows.Forms.Button();
            this.autoClickerSpin = new System.Windows.Forms.NumericUpDown();
            this.hide2Lbl = new System.Windows.Forms.Label();
            this.hideLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.figAmountSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoClickerSpin)).BeginInit();
            this.SuspendLayout();
            // 
            // figAmountSpin
            // 
            this.figAmountSpin.Location = new System.Drawing.Point(61, 195);
            this.figAmountSpin.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.figAmountSpin.Name = "figAmountSpin";
            this.figAmountSpin.ReadOnly = true;
            this.figAmountSpin.Size = new System.Drawing.Size(151, 20);
            this.figAmountSpin.TabIndex = 1;
            // 
            // figClickerBttn
            // 
            this.figClickerBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figClickerBttn.BackgroundImage")));
            this.figClickerBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.figClickerBttn.Location = new System.Drawing.Point(33, 32);
            this.figClickerBttn.Name = "figClickerBttn";
            this.figClickerBttn.Size = new System.Drawing.Size(179, 157);
            this.figClickerBttn.TabIndex = 3;
            this.figClickerBttn.UseVisualStyleBackColor = true;
            this.figClickerBttn.Click += new System.EventHandler(this.figClickerBttn_Click);
            // 
            // figAmountLbl
            // 
            this.figAmountLbl.AutoSize = true;
            this.figAmountLbl.Location = new System.Drawing.Point(30, 197);
            this.figAmountLbl.Name = "figAmountLbl";
            this.figAmountLbl.Size = new System.Drawing.Size(35, 13);
            this.figAmountLbl.TabIndex = 4;
            this.figAmountLbl.Text = "Figs : ";
            this.figAmountLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // noUpDownLbl
            // 
            this.noUpDownLbl.AutoSize = true;
            this.noUpDownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noUpDownLbl.Location = new System.Drawing.Point(187, 197);
            this.noUpDownLbl.Name = "noUpDownLbl";
            this.noUpDownLbl.Size = new System.Drawing.Size(24, 17);
            this.noUpDownLbl.TabIndex = 5;
            this.noUpDownLbl.Text = "    ";
            // 
            // unlock1PrBar
            // 
            this.unlock1PrBar.Location = new System.Drawing.Point(533, 32);
            this.unlock1PrBar.Maximum = 101;
            this.unlock1PrBar.Name = "unlock1PrBar";
            this.unlock1PrBar.Size = new System.Drawing.Size(255, 23);
            this.unlock1PrBar.TabIndex = 6;
            // 
            // autoClickerLbl
            // 
            this.autoClickerLbl.AutoSize = true;
            this.autoClickerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.autoClickerLbl.Location = new System.Drawing.Point(429, 38);
            this.autoClickerLbl.Name = "autoClickerLbl";
            this.autoClickerLbl.Size = new System.Drawing.Size(108, 17);
            this.autoClickerLbl.TabIndex = 7;
            this.autoClickerLbl.Text = "Click Upgrade : ";
            this.autoClickerLbl.Visible = false;
            // 
            // autoClickerBuyBttn
            // 
            this.autoClickerBuyBttn.Location = new System.Drawing.Point(533, 32);
            this.autoClickerBuyBttn.Name = "autoClickerBuyBttn";
            this.autoClickerBuyBttn.Size = new System.Drawing.Size(125, 23);
            this.autoClickerBuyBttn.TabIndex = 8;
            this.autoClickerBuyBttn.Text = "100";
            this.autoClickerBuyBttn.UseVisualStyleBackColor = true;
            this.autoClickerBuyBttn.Visible = false;
            this.autoClickerBuyBttn.Click += new System.EventHandler(this.autoClickerBuyBttn_Click);
            // 
            // autoClickerSpin
            // 
            this.autoClickerSpin.Location = new System.Drawing.Point(664, 35);
            this.autoClickerSpin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.autoClickerSpin.Name = "autoClickerSpin";
            this.autoClickerSpin.ReadOnly = true;
            this.autoClickerSpin.Size = new System.Drawing.Size(120, 20);
            this.autoClickerSpin.TabIndex = 9;
            this.autoClickerSpin.Visible = false;
            // 
            // hide2Lbl
            // 
            this.hide2Lbl.AutoSize = true;
            this.hide2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hide2Lbl.Location = new System.Drawing.Point(742, 35);
            this.hide2Lbl.Name = "hide2Lbl";
            this.hide2Lbl.Size = new System.Drawing.Size(0, 17);
            this.hide2Lbl.TabIndex = 10;
            // 
            // hideLbl
            // 
            this.hideLbl.AutoSize = true;
            this.hideLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hideLbl.Location = new System.Drawing.Point(764, 35);
            this.hideLbl.Name = "hideLbl";
            this.hideLbl.Size = new System.Drawing.Size(20, 17);
            this.hideLbl.TabIndex = 11;
            this.hideLbl.Text = "   ";
            this.hideLbl.Visible = false;
            // 
            // FigClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hideLbl);
            this.Controls.Add(this.hide2Lbl);
            this.Controls.Add(this.autoClickerSpin);
            this.Controls.Add(this.autoClickerBuyBttn);
            this.Controls.Add(this.autoClickerLbl);
            this.Controls.Add(this.unlock1PrBar);
            this.Controls.Add(this.noUpDownLbl);
            this.Controls.Add(this.figAmountSpin);
            this.Controls.Add(this.figAmountLbl);
            this.Controls.Add(this.figClickerBttn);
            this.Name = "FigClicker";
            this.Text = "Fig Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.figAmountSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoClickerSpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown figAmountSpin;
        private System.Windows.Forms.Button figClickerBttn;
        private System.Windows.Forms.Label figAmountLbl;
        private System.Windows.Forms.Label noUpDownLbl;
        private System.Windows.Forms.ProgressBar unlock1PrBar;
        private System.Windows.Forms.Label autoClickerLbl;
        private System.Windows.Forms.Button autoClickerBuyBttn;
        private System.Windows.Forms.NumericUpDown autoClickerSpin;
        private System.Windows.Forms.Label hide2Lbl;
        private System.Windows.Forms.Label hideLbl;
    }
}

