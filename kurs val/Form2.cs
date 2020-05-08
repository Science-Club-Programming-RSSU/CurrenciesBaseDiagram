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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:\\KURSusd.txt", true, System.Text.Encoding.UTF8);
            sw.WriteLine(dateTimePicker1.Text + " " + textBox1.Text);
                        sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 kotusd = new Form4();
            kotusd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 diagusd = new Form6();
            diagusd.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
