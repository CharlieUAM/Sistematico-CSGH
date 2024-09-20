using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] array1 = new int[4,4];
        int[,] array2 = new int[4, 4];
        int count = 0;
        int count2 = 0;
        int number;
        int number2;
        int count3 = 0;
        int count4 = 0;
        int suma;
        int suma2;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || count < 4 || count2 < 4 )
            {
                try
                {
                    int number = Convert.ToInt32(textBox1.Text);
                    number = array1[count, count2];
                    if (count2 == 3)
                    {
                        count2 = 0;
                        count++;
                    }
                    else count2++;
                    textBox1.Clear();
                    textBox1.Focus();
                    
                }
                catch (Exception w) {
                    textBox1.Text = w.Message;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j<4; j++)
                {
                    
                    array1[i,j] += suma;

                }
            }
            
            sum1arry.Text = suma.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || count4 < 4 || count3 < 4 )
            {
               
                    int number = Convert.ToInt32(textBox2.Text);
                    number = array2[count3, count4];
                    if (count4 == 3)
                    {
                        count3 = 0;
                        count++;
                    }
                    else count4++;
                    textBox2.Clear();
                    textBox2.Focus();

              
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    array1[i, j] += suma2;
                }
            }
            sum2arry.Text = suma2.ToString();
        }
        
        private void sum1arry_Click(object sender, EventArgs e)
        {
            
        }
    }
}
