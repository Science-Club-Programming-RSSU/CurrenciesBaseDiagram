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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                var last7 = File.ReadAllLines("D:\\KURSeur.txt");

                if (last7.Length >= 7)
                {
                    for (int i = last7.Length - 7; i < last7.Length; i++)
                    {
                        listBox1.Items.Add(last7[i]);
                    }
                }
            }
            catch
            { 
            }

        }
    }
}
