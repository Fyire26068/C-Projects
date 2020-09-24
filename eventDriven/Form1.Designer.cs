namespace eventDriven
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
            this.submitBttn = new System.Windows.Forms.Button();
            this.firstnameLbl = new System.Windows.Forms.Label();
            this.middlenameLbl = new System.Windows.Forms.Label();
            this.lastnameLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBttn
            // 
            this.submitBttn.Location = new System.Drawing.Point(33, 359);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.Size = new System.Drawing.Size(87, 70);
            this.submitBttn.TabIndex = 0;
            this.submitBttn.Text = "Submit";
            this.submitBttn.UseVisualStyleBackColor = true;
            this.submitBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstnameLbl
            // 
            this.firstnameLbl.AutoSize = true;
            this.firstnameLbl.Location = new System.Drawing.Point(24, 32);
            this.firstnameLbl.Name = "firstnameLbl";
            this.firstnameLbl.Size = new System.Drawing.Size(63, 13);
            this.firstnameLbl.TabIndex = 1;
            this.firstnameLbl.Text = "First Name :";
            this.firstnameLbl.Click += new System.EventHandler(this.firstnameLbl_Click);
            // 
            // middlenameLbl
            // 
            this.middlenameLbl.AutoSize = true;
            this.middlenameLbl.Location = new System.Drawing.Point(13, 58);
            this.middlenameLbl.Name = "middlenameLbl";
            this.middlenameLbl.Size = new System.Drawing.Size(78, 13);
            this.middlenameLbl.TabIndex = 2;
            this.middlenameLbl.Text = "Middle Name : ";
            this.middlenameLbl.Click += new System.EventHandler(this.middlenameLbl_Click);
            // 
            // lastnameLbl
            // 
            this.lastnameLbl.AutoSize = true;
            this.lastnameLbl.Location = new System.Drawing.Point(20, 88);
            this.lastnameLbl.Name = "lastnameLbl";
            this.lastnameLbl.Size = new System.Drawing.Size(67, 13);
            this.lastnameLbl.TabIndex = 3;
            this.lastnameLbl.Text = "Last Name : ";
            this.lastnameLbl.Click += new System.EventHandler(this.lastnameLbl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lastnameLbl);
            this.Controls.Add(this.middlenameLbl);
            this.Controls.Add(this.firstnameLbl);
            this.Controls.Add(this.submitBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBttn;
        private System.Windows.Forms.Label firstnameLbl;
        private System.Windows.Forms.Label middlenameLbl;
        private System.Windows.Forms.Label lastnameLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

