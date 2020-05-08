using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs_val
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 usd = new Form2();
            usd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 eur = new Form3();
            eur.Show();
        }
    }
}
