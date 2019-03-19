using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorInterface
{
    public partial class Form1 : Form
    {
        private MathLibDll.MathLib math;

        public Form1()
        {
            InitializeComponent();
            math = new MathLibDll.MathLib();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(math.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            listBox1.Items.Add(textBox3.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(math.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            listBox1.Items.Add(textBox3.Text);
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(math.Mul(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            listBox1.Items.Add(textBox3.Text);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(math.Div(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            listBox1.Items.Add(textBox3.Text);
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
