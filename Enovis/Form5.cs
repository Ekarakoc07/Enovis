using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Enovis
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string[] words;
        List<string> sayılar = new List<string>();
        List<int> intsayılar = new List<int>();
       
        int b = 0;
        string adres;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                // Listbox'ı temizle
                listBox1.Items.Clear();
                OpenFileDialog open = new OpenFileDialog();
                StreamReader okum;

                /* NOT: @ bu işareti koymamın nedeni \\ 2 defa bundan 
                yapmamak içindir. */

                if (open.ShowDialog() == DialogResult.OK)
                {

                    adres = open.FileName;


                }
                okum = File.OpenText(@adres);

                string yazi;






                char[] delimiterChars = { ',', '.', ':', '\t', ' ' };

                //  Satır boş olana kadar okumaya devam eder.
                while ((yazi = okum.ReadLine()) != null)
                {
                    while (yazi.Contains("  "))
                    {
                        yazi = yazi.Replace("  ", " ");

                    }



                    words = yazi.Split(delimiterChars);
                    foreach (string s in words)
                    {
                        listBox1.Items.Add(s.ToString());
                    }

                }

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (String.IsNullOrEmpty(listBox1.Items[i].ToString()))
                    {
                        //MessageBox.Show("girdi");
                        listBox1.Items.RemoveAt(i);
                    }
                    sayılar.Add(listBox1.Items[i].ToString());

                }

                foreach (string eleman in sayılar)
                {
                    intsayılar.Add(Convert.ToInt32(eleman));
                }
                int[] sırala = new int[intsayılar.Count];
                foreach (int elamanım in intsayılar)
                {

                    sırala[b] = elamanım;
                    b++;
                }
                int degertut;
                for (int i = 0; i < sırala.Length; i++)
                {
                    label2.Text += sırala[i].ToString();
                }
                // MessageBox.Show(sırala.Length.ToString());
                for (int i = 0; i < sırala.Length - 1; i++)
                {
                    for (int j = i + 1; j < sırala.Length; j++)
                    {
                        if (sırala[i] < sırala[j])
                        {
                            degertut = sırala[j];
                            sırala[j] = sırala[i];
                            sırala[i] = degertut;

                        }
                    }


                    //MessageBox.Show(sırala[i].ToString());
                }
                for (int k = 0; k < sırala.Length; k++)
                {

                    label1.Text += sırala[k].ToString() + "    ";



                }
                okum.Close();


            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen karakter");
            }





            }
      
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
           
      }
  
    }

