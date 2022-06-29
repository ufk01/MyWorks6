using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            int Lside, Sside, radius,side;
            double pi = 3.14,area,sphere;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            if (label1.Text.Equals(button1.Text))
            {
                side = Convert.ToInt32(textBox1.Text);
                area = side * side;
                sphere = 4 * side;
               
            }
            else if (label1.Text.Equals(button2.Text))
            {
                Sside = Convert.ToInt32(textBox1.Text);
                Lside = Convert.ToInt32(textBox2.Text);
                area = Sside * Lside;
                sphere = 2 * (Sside + Lside);

            }
            else
            {
                
                radius = Convert.ToInt32(textBox1.Text);
                area = pi * radius * radius;
                sphere = 2 * pi * radius;
            }
            label5.Text = area.ToString();
            label7.Text = sphere.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Square";
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "Enter Length";
            textBox1.Visible = true;
            button4.Visible = true;
            textBox1.Text = null;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Rectangle";
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label2.Text = "Enter Short Length";
            label3.Text = "Enter Long Length";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            textBox1.Text = null;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Circle";
            label1.Visible = false;
            label2.Text = "Enter the radius";
            label2.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox1.Text = null;



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
