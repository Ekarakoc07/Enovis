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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }
        string sayı1;
        string sayı2;
        string sayı3;
        double degertut;
        double Sonuc;

        private void button1_Click(object sender, EventArgs e)
            
        {
            try
            {
                 sayı1 = textBox1.Text;
            sayı2 = textBox2.Text;
           sayı3 = textBox3.Text;
           degertut = (Convert.ToDouble(sayı1) + Convert.ToDouble(sayı2));
            Sonuc = (degertut * Convert.ToDouble(sayı3));
            textBox4.Text = Sonuc.ToString();
            }
            catch (Exception)
            {
                
                MessageBox.Show("lütfen Sayı Giriniz ");
                
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
