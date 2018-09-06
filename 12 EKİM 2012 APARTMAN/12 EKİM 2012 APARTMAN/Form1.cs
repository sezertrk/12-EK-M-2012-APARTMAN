using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12_EKİM_2012_APARTMAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int d = int.Parse(textBox2.Text);
            int t = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < d; j++)
                { t = t + 50; }
            }
            textBox3.Text = t.ToString();
        }
    }
}
