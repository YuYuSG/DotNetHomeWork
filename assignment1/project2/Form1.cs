using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        string s = "";
        int l = 0, r = 0;
        int result = 0;
        char oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"result:{result}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            r = Int32.Parse(s);
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            result = l + r;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            result = l - r;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            result = l * r;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            result = l / r;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            result = l % r;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            l = Int32.Parse(s);
        }
    }
}
