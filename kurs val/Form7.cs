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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        List<int> x;
        List<int> y;
        int[] a;

        private void Form7_Load(object sender, EventArgs e)
        {
            //Инициализация массивов
            x = new List<int>();
            //Чтение файла и запись значений в List x и y
            StreamReader sr = new StreamReader("D:\\KURSeur.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] qwe = line.Split(' ');
                x.Add(Convert.ToInt32(qwe[1]));

            }
            sr.Close();

            chart1.Series["Series1"].LegendText = " ";
            foreach (int val in x)
                chart1.Series["Series1"].Points.Add(val);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
