using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeOdevi
{
    public partial class Form5 : Form
    {

        void message1()
        {
            MessageBox.Show("Eat some shit! (Low)");
        }
        void message2()
        {
            MessageBox.Show("Normal, great! (Normal)");
        }
        void message3()
        {
            MessageBox.Show("Walk forest walk! (Fat)");
        }
        void message4()
        {
            MessageBox.Show("Run forest run! (Too Fat)");
        }
        void message5()
        {
            MessageBox.Show("FOREST, I SAID RUN! (Damn Fat)");
        }
        void message6()
        {
            MessageBox.Show("You have 2 legs right, why don't you use them? (Legless or lazy)");
        }
        void message7()
        {
            MessageBox.Show("What are u? Dead or nonhuman? (Unlisted Value)");
        }

        public Form5()
        {

            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        public static void BMI()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            float length = Convert.ToInt32(textBox1.Text);
            float mass = Convert.ToInt32(textBox2.Text);


            float meterLength = length / 100;
            float bmi = (mass / (meterLength * meterLength));

            if (bmi > 10 && bmi < 18.5)
            {
                message1();
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                message2();
            }
            else if (bmi > 25 && bmi < 29.9)
            {
                message3();
            }
            else if (bmi > 30 && bmi < 34.9)
            {
                message4();
            }
            else if (bmi > 35 && bmi < 39.9)
            {
                message5();
            }
            else if (bmi > 40)
            {
                message6();
            }
            else
            {
                message7();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm2 = new Form1();
            frm2.Show();
        }
    }
}
