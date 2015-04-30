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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 201; i++)
            {
                
                 if (i % 3 == 0 && i % 5 == 0)
                 {
                     if (i > 100)
                     {
                         listView1.Items.Add("zagzig");
                     }
                     else
                     {
                         listView1.Items.Add("zigzag");
                     }
                  }
                 else if (i%3==0)
                {
                    listView1.Items.Add("zig");
                   
                }
                else if(i%5==0){
                listView1.Items.Add("zag");
                }
               
                else if (true)
                {
                    listView1.Items.Add(i.ToString());
                }


                






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
    
