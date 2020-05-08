using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kurs_val
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:\\KURSeur.txt", true, System.Text.Encoding.UTF8);
            sw.WriteLine(dateTimePicker1.Text + " " + textBox1.Text);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 koteur = new Form5();
            koteur.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 diageur = new Form7();
            diageur.Show();
        }
    }
}
