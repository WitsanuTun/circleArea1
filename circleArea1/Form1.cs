using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circleArea1
{
    public partial class Form1 : Form
    {
        double radius;
        double pi = 3.14;
        double circum;
        double area;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void bArea_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void barea_Click(object sender, EventArgs e)
        {
            radius = double.Parse(tRadius.Text);
            area = pi * (radius * radius);
            laArea.Text = area.ToString();
        }

        private void bCircum_Click(object sender, EventArgs e)
        {
            radius = double.Parse(tRadius.Text);
            area= (2 * pi  * radius);
            laCircum.Text = area.ToString();
        }
    }
}
