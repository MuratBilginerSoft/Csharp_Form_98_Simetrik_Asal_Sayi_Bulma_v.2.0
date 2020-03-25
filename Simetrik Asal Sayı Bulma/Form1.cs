using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simetrik_Asal_Sayı_Bulma
{
    public partial class Form1 : Form
    {
        string simetrik1,simetrik2="";
        int simetrik;
        int[] a1 = new int[5000];
        int[] a2 = new int[5000];
        int[] a3 = new int[5000];
        int[] a4 = new int[5000];
        int[] a5 = new int[5000];
        string[] z1 = new string[5];
        int c1 = 1, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
        

        public void asalbulma()
        {
            for (int j = 3; j < 100000; j++)
            {
                int a = 0;

                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        a++;
                        break;
                    }
                }

                if (a == 0)
                {
                    simetrik1 = j.ToString();
                    simetrik2 = "";

                    int y1 = 0;

                    foreach (char t in simetrik1)
                    {
                        z1[y1] = t.ToString();
                        y1++;
                    }

                    int r = z1.Length-1;

                    for (int i = r; i >=0; i--)
                    {
                        simetrik2 += z1[i];
                    }
                    
                     simetrik = int.Parse(simetrik2);

                     int b = 0;

                     for (int i = 2; i < simetrik; i++)
                     {

                         if (simetrik % i == 0)
                         {
                             b++;
                             break;
                         }
                     }

                     if (b == 0)
                     {
                         if (simetrik1.Length == 1)
                         {
                             a1[c1] = j;
                             c1++;
                         }

                         else if (simetrik1.Length == 2)
                         {
                             a2[c2] = j;
                             c2++;
                         }

                         else if (simetrik1.Length == 3)
                         {
                             a3[c3] = j;
                             c3++;
                         }
                         else if (simetrik1.Length == 4)
                         {
                             a4[c4] = j;
                             c4++;
                         }
                         else if (simetrik1.Length == 5)
                         {
                             a5[c5] = j;
                             c5++;
                         }


                     }

                }

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            listBox1.Items.Clear();

            if (comboBox1.Text == "1 Basamaklı")
            {
                for (int i = 0; i < c1; i++)
                {
                    listBox1.Items.Add(a1[i]);
                }
            }

            else if (comboBox1.Text == "2 Basamaklı")
            {
                for (int i = 0; i < c2; i++)
                {
                    listBox1.Items.Add(a2[i]);
                }
            }

            else if (comboBox1.Text == "3 Basamaklı")
            {
                for (int i = 0; i < c3; i++)
                {
                    listBox1.Items.Add(a3[i]);
                }
            }

            else if (comboBox1.Text == "4 Basamaklı")
            {
                for (int i = 0; i < c4; i++)
                {
                    listBox1.Items.Add(a4[i]);
                }
            }

            else if (comboBox1.Text == "5 Basamaklı")
            {
                for (int i = 0; i < c5 - 1; i++)
                {
                    listBox1.Items.Add(a5[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            asalbulma();
            a1[0] = 2;
        }
    }
}
