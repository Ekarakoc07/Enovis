using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enovis
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int[] dizi;
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                a = Convert.ToInt16(textBox1.Text);
                  dizi=new int[a];
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen sıfırdan büyük sayı giriniz");
                
            }
           
            if (a > 0 && a > 1)
            {
                dizi[0] = 0;
                dizi[1] = 1;
                for (int i = 2; i < a; i++)
                {
                    dizi[i] = dizi[i - 1] + dizi[i - 2];
                }
                label1.Text = dizi[a - 1].ToString();
            }
            else if (a==0)
            {
                label1.Text ="0";
            } else if (a==1)
            {
                label1.Text ="1";
            }
            else
            {
                
            }
           
            

            
               
                
            
           







        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
