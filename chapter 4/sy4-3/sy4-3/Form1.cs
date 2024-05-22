using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sy4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            float num = float.Parse(textBox1.Text);
            FontStyle fontStyle = FontStyle.Regular;
            Color color = Color.Black;
            if (radioButton1.Checked)
            {
                textBox2.Text = Math.Round(Math.Sin(num),2).ToString();
            }
            if (radioButton2.Checked)
            {
                textBox2.Text = Math.Round(Math.Cos(num), 2).ToString();
            }
            if(radioButton3.Checked)
            {
                textBox2.Text = Math.Round(Math.Tan(num), 2).ToString();
            }
            if(checkBox1.Checked)
            {
                fontStyle = fontStyle | FontStyle.Bold;
            }
            if (checkBox2.Checked)
            {
                fontStyle = fontStyle | FontStyle.Italic;
            }
            if(checkBox3.Checked)
            {
                color = Color.Red;
            }

            textBox2.ForeColor = color;
            textBox2.Font = new Font("宋体",9,fontStyle);
        }
    }
}
