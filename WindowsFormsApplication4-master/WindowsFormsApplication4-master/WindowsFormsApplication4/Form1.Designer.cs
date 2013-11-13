namespace WindowsFormsApplication3
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.dpt3 = new System.Windows.Forms.RadioButton();
            this.dpt2 = new System.Windows.Forms.RadioButton();
            this.dpt1 = new System.Windows.Forms.RadioButton();
            this.cpt3 = new System.Windows.Forms.RadioButton();
            this.cpt2 = new System.Windows.Forms.RadioButton();
            this.cpt1 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bpt1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bpt2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(173, 477);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(100, 28);
            this.cmdCheck.TabIndex = 39;
            this.cmdCheck.Text = "เรียบร้อย";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // dpt3
            // 
            this.dpt3.AutoSize = true;
            this.dpt3.Location = new System.Drawing.Point(6, 46);
            this.dpt3.Name = "dpt3";
            this.dpt3.Size = new System.Drawing.Size(127, 17);
            this.dpt3.TabIndex = 22;
            this.dpt3.Text = "ข้อมูลเชิงการท่องเที่ยว";
            this.dpt3.UseVisualStyleBackColor = true;
            // 
            // dpt2
            // 
            this.dpt2.AutoSize = true;
            this.dpt2.Location = new System.Drawing.Point(149, 23);
            this.dpt2.Name = "dpt2";
            this.dpt2.Size = new System.Drawing.Size(165, 17);
            this.dpt2.TabIndex = 21;
            this.dpt2.Text = "ศึกษาค้นคว้าเพื่อจัดทำรายงาน";
            this.dpt2.UseVisualStyleBackColor = true;
            // 
            // dpt1
            // 
            this.dpt1.AutoSize = true;
            this.dpt1.Checked = true;
            this.dpt1.Location = new System.Drawing.Point(6, 23);
            this.dpt1.Name = "dpt1";
            this.dpt1.Size = new System.Drawing.Size(119, 17);
            this.dpt1.TabIndex = 20;
            this.dpt1.TabStop = true;
            this.dpt1.Text = "จัดการเรียนการสอน";
            this.dpt1.UseVisualStyleBackColor = true;
            // 
            // cpt3
            // 
            this.cpt3.AutoSize = true;
            this.cpt3.Location = new System.Drawing.Point(6, 51);
            this.cpt3.Name = "cpt3";
            this.cpt3.Size = new System.Drawing.Size(181, 17);
            this.cpt3.TabIndex = 19;
            this.cpt3.Text = "แผ่นพับประชาสัมพันธ์ที่ได้รับแจก";
            this.cpt3.UseVisualStyleBackColor = true;
            // 
            // cpt2
            // 
            this.cpt2.AutoSize = true;
            this.cpt2.Location = new System.Drawing.Point(192, 28);
            this.cpt2.Name = "cpt2";
            this.cpt2.Size = new System.Drawing.Size(103, 17);
            this.cpt2.TabIndex = 18;
            this.cpt2.Text = "www.yahoo.com";
            this.cpt2.UseVisualStyleBackColor = true;
            // 
            // cpt1
            // 
            this.cpt1.AutoSize = true;
            this.cpt1.Checked = true;
            this.cpt1.Location = new System.Drawing.Point(6, 28);
            this.cpt1.Name = "cpt1";
            this.cpt1.Size = new System.Drawing.Size(110, 17);
            this.cpt1.TabIndex = 17;
            this.cpt1.TabStop = true;
            this.cpt1.Text = "www.google.co.th";
            this.cpt1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.radioButton5);
            this.groupBox6.Controls.Add(this.dpt3);
            this.groupBox6.Controls.Add(this.dpt2);
            this.groupBox6.Controls.Add(this.dpt1);
            this.groupBox6.Location = new System.Drawing.Point(52, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(398, 117);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3.แหล่งเรียนรู้และภูมิท้องถิ่นไปใช้ประโยชน์อย่างไรบ้าง";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 69);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(290, 20);
            this.textBox3.TabIndex = 23;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 69);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(50, 17);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.Text = "อื่น ๆ ";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Text = "อบต.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(213, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "อบจ.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bpt1
            // 
            this.bpt1.AutoSize = true;
            this.bpt1.Checked = true;
            this.bpt1.Location = new System.Drawing.Point(6, 29);
            this.bpt1.Name = "bpt1";
            this.bpt1.Size = new System.Drawing.Size(66, 17);
            this.bpt1.TabIndex = 12;
            this.bpt1.TabStop = true;
            this.bpt1.Text = "โรงเรียน";
            this.bpt1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.radioButton11);
            this.groupBox5.Controls.Add(this.radioButton10);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.cpt3);
            this.groupBox5.Controls.Add(this.cpt2);
            this.groupBox5.Controls.Add(this.cpt1);
            this.groupBox5.Location = new System.Drawing.Point(52, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 128);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "2.ท่านได้รับข่าวสารข้อมูลจากแหล่งใด";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 102);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 20);
            this.textBox2.TabIndex = 20;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 100);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(47, 17);
            this.radioButton11.TabIndex = 22;
            this.radioButton11.Text = "อื่น ๆ";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 74);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(75, 17);
            this.radioButton10.TabIndex = 21;
            this.radioButton10.Text = "การบอกต่อ";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(192, 51);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(140, 17);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.Text = "แผ่นซีดีข้อมูลที่ได้รับแจก";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "แบบประเมินประสิทธิภาพการจัดทำโพลด์ของศูนย์วิจัยมหาลีย";
            // 
            // bpt2
            // 
            this.bpt2.AutoSize = true;
            this.bpt2.Location = new System.Drawing.Point(107, 29);
            this.bpt2.Name = "bpt2";
            this.bpt2.Size = new System.Drawing.Size(65, 17);
            this.bpt2.TabIndex = 13;
            this.bpt2.Text = "เทศบาล ";
            this.bpt2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.radioButton9);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.bpt1);
            this.groupBox4.Controls.Add(this.bpt2);
            this.groupBox4.Location = new System.Drawing.Point(54, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 118);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = ".1.หน่วยงานที่สังกัด";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 19;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 75);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(47, 17);
            this.radioButton9.TabIndex = 18;
            this.radioButton9.Text = "อื่น ๆ";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(213, 52);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(79, 17);
            this.radioButton8.TabIndex = 17;
            this.radioButton8.Text = "กศน.อำเภอ";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "กศน.จังหวัด";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 549);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.RadioButton dpt3;
        private System.Windows.Forms.RadioButton dpt2;
        private System.Windows.Forms.RadioButton dpt1;
        private System.Windows.Forms.RadioButton cpt3;
        private System.Windows.Forms.RadioButton cpt2;
        private System.Windows.Forms.RadioButton cpt1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton bpt1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bpt2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

