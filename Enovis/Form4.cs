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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            try
            {

                int a = Convert.ToInt32(textBox1.Text);

                if (a <= 0 || a > 15)
                {
                    MessageBox.Show("lütfen 1 ile 16 arası sayı giriniz");
                }
                else
                {

                    int[,] dizi = new int[a, a];


                    for (int i = 0; i < 1; i++)
                    {

                        for (int j = 0; j < a; j++)
                        {
                            dizi[i, j] = j;
                        }
                        for (int m = 0; m < 1; m++)
                        {
                            for (int n = 1; n < a; n++)
                            {
                                dizi[n, m] = n;
                            }

                        }
                        for (int k = 1; k < a; k++)
                        {
                            for (int l = 1; l < a; l++)
                            {

                                dizi[k, l] = l * k;
                            }

                        }

                        for (int f = 0; f < a; f++)
                        {
                            for (int n = 0; n < a; n++)
                            {
                                label1.Text += dizi[f, n].ToString() + "   ";
                            }
                            label1.Text += "\n";
                        }

                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Deger giriniz");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
