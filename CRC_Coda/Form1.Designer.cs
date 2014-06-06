namespace CRC_Coda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFullCRC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullByte4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullByte3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullByte2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtB3Sec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtB3CRC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInCRC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtB3First = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtFullCRC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFullByte4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFullByte3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFullByte2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 184);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Full Calc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "All numbers in hex";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFullCRC
            // 
            this.txtFullCRC.Location = new System.Drawing.Point(50, 152);
            this.txtFullCRC.Name = "txtFullCRC";
            this.txtFullCRC.Size = new System.Drawing.Size(50, 20);
            this.txtFullCRC.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "CRC";
            // 
            // txtFullByte4
            // 
            this.txtFullByte4.Location = new System.Drawing.Point(50, 99);
            this.txtFullByte4.Name = "txtFullByte4";
            this.txtFullByte4.Size = new System.Drawing.Size(50, 20);
            this.txtFullByte4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Byte 4";
            // 
            // txtFullByte3
            // 
            this.txtFullByte3.Location = new System.Drawing.Point(50, 76);
            this.txtFullByte3.Name = "txtFullByte3";
            this.txtFullByte3.Size = new System.Drawing.Size(50, 20);
            this.txtFullByte3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Byte 3";
            // 
            // txtFullByte2
            // 
            this.txtFullByte2.Location = new System.Drawing.Point(50, 53);
            this.txtFullByte2.Name = "txtFullByte2";
            this.txtFullByte2.Size = new System.Drawing.Size(50, 20);
            this.txtFullByte2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Byte 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtB3Sec);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtB3CRC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtInCRC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtB3First);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(158, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 184);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calc Based on Diff In Byte 3";
            // 
            // txtB3Sec
            // 
            this.txtB3Sec.Location = new System.Drawing.Point(71, 99);
            this.txtB3Sec.Name = "txtB3Sec";
            this.txtB3Sec.Size = new System.Drawing.Size(50, 20);
            this.txtB3Sec.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sec. Byte 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "All numbers in hex";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtB3CRC
            // 
            this.txtB3CRC.Location = new System.Drawing.Point(71, 152);
            this.txtB3CRC.Name = "txtB3CRC";
            this.txtB3CRC.Size = new System.Drawing.Size(50, 20);
            this.txtB3CRC.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "CRC";
            // 
            // txtInCRC
            // 
            this.txtInCRC.Location = new System.Drawing.Point(71, 76);
            this.txtInCRC.Name = "txtInCRC";
            this.txtInCRC.Size = new System.Drawing.Size(50, 20);
            this.txtInCRC.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "CRC for first:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtB3First
            // 
            this.txtB3First.Location = new System.Drawing.Point(71, 53);
            this.txtB3First.Name = "txtB3First";
            this.txtB3First.Size = new System.Drawing.Size(50, 20);
            this.txtB3First.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "First Byte 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Coda CRC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFullCRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullByte4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullByte3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullByte2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtB3CRC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInCRC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtB3First;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtB3Sec;
        private System.Windows.Forms.Label label8;

    }
}

