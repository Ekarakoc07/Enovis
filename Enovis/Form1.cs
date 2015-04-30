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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void iki() {
            
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (comboBox1.SelectedItem.ToString()=="işlevsel 1")
                 {
                label2.Text = "1";
                label3.Text = "Sayı girebileceğiniz üç tane textbox bulunuyor. Bu textbox’lara sayılar gireceksiniz." + "\n" + "“Sonucu Göster” düğmesine bastığınızda ilk iki textbox’a girilen sayıların toplamı ile" + "\n" + "üçüncü textbox’a girilen sayı ile çarpıp sonucu dördüncü bir textbox’ta göreceksiniz" + "\n"+" "+ "\n" + "Bu Projeyi Seçmek için Lütfen  ileri butonuna basınız ";
                  }
            else if (comboBox1.SelectedItem.ToString() == "işlevsel 2")
                  {
                label2.Text = "2";
                label3.Text = "Buttona bastıgınızda ekrana 1’den 200’e kadar olan sayılar yazılacak." + "\n" + "Ancak sayı 3’ün katı ise sayının yerine ‘zig’ yazılacak" + "\n" + "sayı 5’in katı ise sayının yerine ‘zag’ yazılacak."+"\n"+"Sayı hem 3’ün hem de 5’in katı ise ‘zigzag’ yazılacak." + "\n" + "100’den sonra ‘zigzag’ yerine ‘zagzig’ yazılacak." + "\n" +"" + "\n" + "Bu Projeyi Seçmek için Lütfen  ileri butonuna basınız ";
                  }
            else if (comboBox1.SelectedItem.ToString() == "işlevsel 3")
                  {
                label2.Text = "3";
                label3.Text = "Textbox’a 1’den 15’e kadar  tam sayı yazabilirsiniz." + "\n" + "Kaç yazarsanız, düğmeye bastığınızda" + "\n" + "ekranda, o sayıya kadar olan çarpım tablosunu göreceksiniz." + "\n" + " " + "\n" + "Bu Projeyi Seçmek için Lütfen  ileri butonuna basınız ";
                   }
            else if (comboBox1.SelectedItem.ToString() == "işlevsel 4")
                   {
                label2.Text = "4";
                label3.Text = "Bilgisayarınizdan bir metin dosyası seçin. " + "\n" + "Bu metin dosyasında integer sayılar olacak. "+"\n"+"Bu sayılar “white-space” karakterleri ile ayrılmış olabilir." + "\n" + "Metin dosyasındaki sayı miktarı belirsizdir. " + "\n" + "Dosyayı seçip buttona tıkladığınızda metin dosyasındaki tüm sayıları " + "\n" + "BÜYÜKTEN KÜÇÜĞE DOĞRU SIRALANMIŞ bir biçimde ekranda göreceksiniz." + "\n" + "" + "\n" + "Bu Projeyi Seçmek için Lütfen  ileri butonuna basınız ";
                    }
            else if (comboBox1.SelectedItem.ToString() == "işlevsel 5")
                    {
                label2.Text = "5";
                label3.Text = "Bir textbox’a kaç yazarsam, düğmeye basıldığınızda,"+"\n"+" ekranda, o sıradaki Fibonacci sayısını göreceksiniz." + "\n" + "Örneğin kutuya 8 yazarsanız, ekranda 13 göreceksiniz."+"\n"+" Fibonacci serisinin ilk iki rakkamı 0 ve 1’dir." + "\n"+" "+ "\n" + "Bu Projeyi Seçmek için Lütfen  ileri butonuna basınız ";
                    }
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(label2.Text)) {
        case 1 :
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            break;
 
        case 2 :
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
            break;
 
        case 3 :
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
            break;
 
        case 4 :
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
            break;
         default  :
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
            break;
        }
        }
    }
}

    
        
