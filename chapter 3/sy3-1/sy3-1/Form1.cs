﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sy3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class circle
        {
            private double x;
            private double y;
            private double radius;

            public double getx
            {
                set
                {
                    x = value;
                }
                get
                {
                    return x;
                }
            }
            public double gety
            {
                set
                {
                    y = value;
                }
                get
                {
                    return y;
                }
            }
            public double getradius
            {
                set
                {
                    radius = value;
                }
                get
                {
                    return radius;
                }
            }
            public double GetArea
            {
                get
                {
                    return Math.Pow(radius,2) * Math.PI;
                }
            }
            public double GetPerimeter
            {
                get
                {
                    return 2 * radius * Math.PI;
                }
            }

            public double GetDistance
            {
                get
                {
                    return Math.Sqrt(x*x + y*y);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle cir = new circle();
            cir.getx = double.Parse(textBox1.Text);
            cir.gety = double.Parse(textBox2.Text);
            cir.getradius = double.Parse(textBox3.Text);
            textBox4.Text = string.Format("{0:0.00}", cir.GetArea);
            textBox5.Text = string.Format("{0:0.00}", cir.GetPerimeter);
            textBox6.Text = string.Format("{0:0.00}", cir.GetDistance);
        }
    }
}
