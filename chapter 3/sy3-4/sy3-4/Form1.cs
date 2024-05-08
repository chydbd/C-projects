using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sy3_4
{
    public partial class Form1 : Form
    {
        class Vehicle
        {
            protected int wheels;
            protected float weight;

            public void setVehicle(int wheels, float weight)
            {
                this.wheels = wheels;
                this.weight = weight;
            }
        }

        class Truck : Vehicle
        {
            private float load;
            private float consume;
            private float loading;
            private float mileage;
            public new void setVehicle(int wheels, float weight, float load, float consume, float loading, float mileage)
            {
                this.wheels = wheels;
                this.weight = weight;
                this.load = load;
                this.consume = consume;
                this.loading = loading;
                this.mileage = mileage;
            }

            public Boolean isOverload
            {
                get
                {
                    if (loading > load)
                        return true;
                    else
                        return false;
                }
            }

            public float consumed
            {
                get
                {
                    return consume * mileage;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wheels = int.Parse(textBox1.Text);
            float weight = float.Parse(textBox2.Text);
            float load = float.Parse(textBox3.Text);
            float consume = float.Parse(textBox4.Text);
            float loaded = float.Parse(textBox7.Text);
            float mileage = float.Parse(textBox6.Text);
            Truck truck = new Truck();
            truck.setVehicle(wheels,weight,load,consume,loaded,mileage);
            if (truck.isOverload)
            {
                MessageBox.Show("对不起！卡车已超重，请卸下一些货物。");
                textBox7.Text = "";
                textBox7.Focus();
                return;
            }
            float consumed = truck.consumed;
            MessageBox.Show("卡车正在行驶中...\n现已耗油" + consumed.ToString() + "升！");
        }
    }
}
