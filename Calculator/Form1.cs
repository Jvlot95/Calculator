using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string input = String.Empty;


        public Form1()
        {
            InitializeComponent();
            zero.Click += numericEventHandler;
            one.Click += numericEventHandler;
            two.Click += numericEventHandler;
            three.Click += numericEventHandler;
            four.Click += numericEventHandler;
            five.Click += numericEventHandler;
            six.Click += numericEventHandler;
            seven.Click += numericEventHandler;
            eight.Click += numericEventHandler;
            nine.Click += numericEventHandler;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericEventHandler( object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += (sender as Button).Text;
            this.textBox1.Text = input;
        }

        private void comma_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void subtract_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void percent_Click(object sender, EventArgs e)
        {

        }

        private void solution_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}
