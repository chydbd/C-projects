using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox1.Text);
            }catch(Exception)
            {
                MessageBox.Show("请输入整数");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = "";
            selected += comboBox1.Text + Environment.NewLine;
            selected += textBox1.Text + "G内存" + Environment.NewLine;
            if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (radioButton1.Checked)
                {
                    selected += radioButton1.Text + Environment.NewLine;
                }
                else if (radioButton2.Checked)
                {
                    selected += radioButton2.Text + Environment.NewLine;
                }
                else
                {
                    selected += radioButton3.Text + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("请选择CPU");
            }

            if(radioButton4.Checked || radioButton5.Checked || radioButton6.Checked)
            {
                if (radioButton4.Checked)
                {
                    selected += radioButton4.Text + Environment.NewLine;
                }
                else if (radioButton5.Checked)
                {
                    selected += radioButton5.Text + Environment.NewLine;
                }
                else
                {
                    selected += radioButton6.Text + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("请选择电脑种类");
            }

            if(checkBox1.Checked) selected += checkBox1.Text + Environment.NewLine;
            if(checkBox2.Checked) selected += checkBox2.Text + Environment.NewLine;
            if(checkBox3.Checked) selected += checkBox3.Text + Environment.NewLine;

            textBox2.Text = selected;
        }
    }
}
