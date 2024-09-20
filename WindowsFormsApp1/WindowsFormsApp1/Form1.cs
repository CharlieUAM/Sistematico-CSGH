using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangoNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(texBoxX.Text, out int x) && int.TryParse(texBoxY.Text, out int y))
            {
                texBoxResult.Clear();
                if (x > y)



                {
                    Console.WriteLine("Numeros en orden inverso");
                    for (int i = x; i >= y; i--) ;
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Numeros en orden normal");
                    for (int i = x; i <= y; i++) ;
                    {
                        texBoxResult.AppendText(AppendText(i + Environment.NewLine);
                    }
                }
            }
            {
            else
                    MessageBox.Show("Por favor ingrese Numeros Validos", "Error", MessageBoxButtoms.Ok, MessageBoxIcon.Error);
            }
        }
    }
}

