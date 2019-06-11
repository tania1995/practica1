using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array;
            int num, mayores, menores, iguales, n;
            mayores = 0;
            menores = 0;
            iguales = 0;
            n = int.Parse(textBox1.Text);
            array = new int[7];
            comboBox1.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("INGRESE UN NUMERO " + (i + 1) + " :"));
                array[i] = num;
                comboBox1.Items.Add(array[i]);
                if (array[i] == n)
                {
                    iguales = iguales + 1;
                }
                else
                {
                    if (array[i] > n)
                    {
                        mayores = mayores + 1;
                    }
                    else
                    {
                        menores = menores + 1;
                    }
                }
            }
            textBox2.Text = mayores.ToString();
            textBox3.Text = iguales.ToString();
            textBox4.Text = menores.ToString();
        }
    }
}
