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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                                }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                var last7 = File.ReadAllLines("D:\\KURSusd.txt");
                if (last7.Length >= 7)
                {
                    for (int i = last7.Length - 7; i < last7.Length; i++)
                    {
                        listBox1.Items.Add(last7[i]);
                    }
                }
            }
            catch
            { }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
