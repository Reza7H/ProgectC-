using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectC_
{
    public partial class Form1 : Form
    {
        List<double> numbers = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value;
            if(double.TryParse(textBox1.Text, out value))
            {
                numbers.Add(value);
               listBox1.Items.Add(value);
               textBox1.Clear();
                textBox1.Focus(); 
            }
            else
            {
                MessageBox.Show("Enter Correct Price");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shopping TimeLine:"+"\n" +DateTime.Now.ToString());
        }
    }
}
