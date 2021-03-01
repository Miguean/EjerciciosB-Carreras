using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Carreras_de_Juan_Carlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            tbxPromedio.Text = Math.Round((((Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) / 60))
                + (Convert.ToDouble(textBox3.Text) / (Convert.ToDouble(textBox4.Text) / 60))
                + (Convert.ToDouble(textBox5.Text) / (Convert.ToDouble(textBox6.Text) / 60))
                + (Convert.ToDouble(textBox7.Text) / (Convert.ToDouble(textBox8.Text) / 60))) / 4),2).ToString();
            tbxPromedio.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            tbxPromedio.Clear();
            textBox1.Focus();
        }
    }
}
