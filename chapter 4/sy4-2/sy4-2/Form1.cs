using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sy4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add(listBox2.Text);
            listBox2.Items.Remove(listBox2.Text);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listBox2.Items.Count > 4)
                {
                    throw new Exception();
                }
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
            }
            catch
            {
                MessageBox.Show("最多选五门课");
            }
        }
    }
}
