using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("   Celsius\t\tFahrenheit");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int celsius = 0; celsius <= 20; celsius++)
            {
                double fahrenheit = (9.0 / 5.0) * celsius + 32;
                listBox1.Items.Add("     " + celsius + "°C\t\n="+"\t" + fahrenheit + "  °F");

            }
        }
    }
}
