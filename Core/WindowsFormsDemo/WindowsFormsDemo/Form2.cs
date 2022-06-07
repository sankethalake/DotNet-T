using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string str;
            DriveInfo[] dr = DriveInfo.GetDrives();
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                listBox1.Items.Add(d);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            string[] dr1 = Directory.GetDirectories(str);
            foreach (string d in dr1)
            {
                listBox2.Items.Add(d);
            }
            //listBox2.Items.Add(listBox1.SelectedItem);
        }
    }
}
