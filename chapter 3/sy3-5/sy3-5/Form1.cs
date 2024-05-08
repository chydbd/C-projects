using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sy3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class CountDistance
        {
            private float distance;
            private static float totalDistance;

            public static float TotalDistance
            {
                set { totalDistance = value; }
                get { return totalDistance; }
            }

            public float Distance
            {
                set { distance = value; }
                get { return distance; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountDistance distance = new CountDistance();
            distance.Distance = float.Parse(textBox1.Text);
            CountDistance.TotalDistance += distance.Distance;
            MessageBox.Show("您的汽车已行驶" + CountDistance.TotalDistance + "公里");
        }
    }
}
