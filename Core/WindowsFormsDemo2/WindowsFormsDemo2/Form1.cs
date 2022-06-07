using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo2
{
    public partial class Form1 : Form
    {
        public static int deptno =0;
        public static string dname = ""; 
        public static string loc = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deptno = Convert.ToInt32(textBox1.Text);
            dname = textBox2.Text;
            loc = textBox3.Text;

            Form2 fobj = new Form2();
            fobj.Show();
        }
    }
}
