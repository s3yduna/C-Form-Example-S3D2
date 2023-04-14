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
    public partial class Form1 : Form
    {
        //s3yduna
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e) 
        {
            Form3 form3sec = new Form3();
            form3sec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Already Logged in!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4sec = new Form4();
            form4sec.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5sec = new Form5();
            form5sec.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateCalculator form6frm = new DateCalculator();
            form6frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            unknown form7frm = new unknown();
            form7frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
