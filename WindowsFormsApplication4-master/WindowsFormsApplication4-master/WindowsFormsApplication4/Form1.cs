using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str;
            string n;
            string m;


            

            
            if (bpt1.Checked == true)
            {
                str =  "โรงเรียน" ;
            }
            else if (bpt2.Checked == true)
            {
                str = "เทศบาล";
            }
            else  if (radioButton1.Checked == true)
            {
                str =  "อบจ." ;

            }
            else   if (radioButton3.Checked == true)
            {
                str =  "อบต." ;
            }
            else   if (radioButton8.Checked == true)
            {
                str =  "กศน.อำเภอ" ;
            }
            else  if (radioButton2.Checked == true)
            {
                str =  "กศน.จังหวัด" ;
            }
            else if (radioButton9.Checked == true)
            {
                if (textBox1.Text == "")
                {
                    str = "กรุณากรอกข้อมูล";
                }
                else
                {
                    str = "อื่น ๆ : "+ textBox1 .Text ;
                }
            }else 
            {
                str = "โรงเรียน";
            }
            {
            }
           // str = str + "2.ท่านได้รับข่าวสารข้อมูลจากแหล่งใด ===";
            if (cpt1.Checked == true)
            {
                n =  "www.google.co.th" ;
            }
            else  if (cpt2.Checked == true)
            {
                n = "www.yahoo.com" ;
            }
            else   if (cpt3.Checked == true)
            {
               n= "แผ่นพับประชาสัมพันธ์ที่ได้รับแจก"  ;
            }
            else  if (radioButton4.Checked == true)
            {
                n= "แผ่นซีดีข้อมูลที่ได้รับแจก"  ;
            }
            else   if (radioButton10.Checked == true)
            {
              n= "การบอกต่อ"  ;
            }
            else  if (radioButton11.Checked == true)
            {
                if (textBox2.Text == "")
                {
                    n = "กรุณากรอกข้อมูล";
                }
                else
                {
                    n = "อื่น ๆ : " + textBox2.Text;
                }
            }
                else
            {
                {
                    n = "www.google.co.th";
                }

            }
           // str = str + "3.แหล่งเรียนรู้และภูมิท้องถิ่นไปใช้ประโยชน์อย่างไรบ้าง ===";
            if (dpt1.Checked == true)
            {
                m= "จัดการเรียนการสอน" ;
            }
            else   if (dpt2.Checked == true)
            {
                m= "ศึกษาค้นคว้าและทำรายงาน"  ;
            }
            else  if (dpt3.Checked == true)
            {
                m= "ข้อมูลเชิงการท่องเที่ยว"  ;
            }
            else if (radioButton5.Checked == true)
            {
                if (textBox3.Text == "")
                {
                    m = "กรุณากรอกข้อมูล";
                }
                else
                {
                    m = "อื่น ๆ : " + textBox3.Text;
                }
            }
            else
            {
                m = "จัดการเรียนการสอน";
            }
            {   
           









            }
            Form2 frm = new Form2(str ,n ,m );
            frm.Show();
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

