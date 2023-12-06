using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox4.Text), //left
                b = Convert.ToInt32(textBox5.Text), // right
                d = Convert.ToInt32(textBox1.Text),
                s = Convert.ToInt32(textBox2.Text),
                f = Convert.ToInt32(textBox3.Text),
                h = 0.01, //step
                x, y;
            this.chart1.Series["Sin(x)"].Points.Clear();
            this.chart1.Series["Cos(x)"].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Sin(((d * x) + s) + f);
                this.chart1.Series["Sin(x)"].Points.AddXY(x, y);
                x += h;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox4.Text), //left
                b = Convert.ToInt32(textBox5.Text), // right
                d = Convert.ToInt32(textBox1.Text),
                s = Convert.ToInt32(textBox2.Text),
                f = Convert.ToInt32(textBox3.Text),
                h = 0.01, //step
                x, y;
            this.chart1.Series["Sin(x)"].Points.Clear();
            this.chart1.Series["Cos(x)"].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Cos(((d * x) + s) + f);
                this.chart1.Series["Cos(x)"].Points.AddXY(x, y);
                x += h;
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox4.Text), //left
                b = Convert.ToInt32(textBox5.Text), // right
                d = Convert.ToInt32(textBox1.Text),
                s = Convert.ToInt32(textBox2.Text),
                f = Convert.ToInt32(textBox3.Text),
                h = 0.01, //step
                x, y;
            this.chart1.Series["Sin(x)"].Points.Clear();
            this.chart1.Series["Cos(x)"].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Sin(((d * x) + s) + f);
                this.chart1.Series["Sin(x)"].Points.AddXY(x, y);
                y = Math.Cos(((d * x) + s) + f);
                this.chart1.Series["Cos(x)"].Points.AddXY(x, y);
                x += h;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
