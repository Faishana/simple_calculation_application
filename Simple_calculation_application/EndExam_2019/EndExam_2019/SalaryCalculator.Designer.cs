namespace EndExam_2019
{
    partial class SalaryCalculator
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.labelBS = new System.Windows.Forms.Label();
            this.labelTA = new System.Windows.Forms.Label();
            this.labelGP = new System.Windows.Forms.Label();
            this.labelTD = new System.Windows.Forms.Label();
            this.labelNP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the staff name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Basic salary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(47, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Total Allowence";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(47, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Gross pay";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(47, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Total deduction";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(47, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "Net pay";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Salmon;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(329, 541);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "Print";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelBS
            // 
            this.labelBS.AutoSize = true;
            this.labelBS.Location = new System.Drawing.Point(258, 167);
            this.labelBS.Name = "labelBS";
            this.labelBS.Size = new System.Drawing.Size(81, 20);
            this.labelBS.TabIndex = 8;
            this.labelBS.Text = "************";
            // 
            // labelTA
            // 
            this.labelTA.AutoSize = true;
            this.labelTA.Location = new System.Drawing.Point(258, 235);
            this.labelTA.Name = "labelTA";
            this.labelTA.Size = new System.Drawing.Size(81, 20);
            this.labelTA.TabIndex = 9;
            this.labelTA.Text = "************";
            // 
            // labelGP
            // 
            this.labelGP.AutoSize = true;
            this.labelGP.Location = new System.Drawing.Point(258, 309);
            this.labelGP.Name = "labelGP";
            this.labelGP.Size = new System.Drawing.Size(81, 20);
            this.labelGP.TabIndex = 10;
            this.labelGP.Text = "************";
            // 
            // labelTD
            // 
            this.labelTD.AutoSize = true;
            this.labelTD.Location = new System.Drawing.Point(258, 377);
            this.labelTD.Name = "labelTD";
            this.labelTD.Size = new System.Drawing.Size(81, 20);
            this.labelTD.TabIndex = 11;
            this.labelTD.Text = "************";
            // 
            // labelNP
            // 
            this.labelNP.AutoSize = true;
            this.labelNP.Location = new System.Drawing.Point(258, 444);
            this.labelNP.Name = "labelNP";
            this.labelNP.Size = new System.Drawing.Size(81, 20);
            this.labelNP.TabIndex = 12;
            this.labelNP.Text = "************";
            this.labelNP.Click += new System.EventHandler(this.label6_Click);
            // 
            // SalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(577, 629);
            this.Controls.Add(this.labelNP);
            this.Controls.Add(this.labelTD);
            this.Controls.Add(this.labelGP);
            this.Controls.Add(this.labelTA);
            this.Controls.Add(this.labelBS);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculator";
            this.Text = "SalaryCalculator";
            this.Load += new System.EventHandler(this.SalaryCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelBS;
        private System.Windows.Forms.Label labelTA;
        private System.Windows.Forms.Label labelGP;
        private System.Windows.Forms.Label labelTD;
        private System.Windows.Forms.Label labelNP;
    }
}