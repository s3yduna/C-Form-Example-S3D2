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
    public partial class Form4 : Form
    {

        
        public Form4()
        {

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void resultToplama()
        {
            
            int userNumber = Convert.ToInt32(userNumberTxt1.Text);
            int userNumber2 = Convert.ToInt32(userNumberTxt2.Text);

            int sonucToplama = toplama(userNumber, userNumber2);
            label3.Text = sonucToplama.ToString();
        }
        public void resultCikarma()
        {

            int userNumber = Convert.ToInt32(userNumberTxt1.Text);
            int userNumber2 = Convert.ToInt32(userNumberTxt2.Text);

            int sonucCikarma = cikarma(userNumber, userNumber2);
            label3.Text = sonucCikarma.ToString();
        }
        public void resultCarpma()
        {

            int userNumber = Convert.ToInt32(userNumberTxt1.Text);
            int userNumber2 = Convert.ToInt32(userNumberTxt2.Text);

            int sonucCarpma = carpma(userNumber, userNumber2);
            label3.Text = sonucCarpma.ToString();
        }
        public void resultBolme()
        {

            int userNumber = Convert.ToInt32(userNumberTxt1.Text);
            int userNumber2 = Convert.ToInt32(userNumberTxt2.Text);

            int sonucBolme = bolme(userNumber, userNumber2);
            label3.Text = sonucBolme.ToString();
        }

            
        static int toplama(int a, int b)
        {
            return a + b;
        }

        static int cikarma(int a, int b)
        {
            return a - b;
        }

        static int carpma(int a, int b)
        {
            return a * b;
        }

        static int bolme(int a, int b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultToplama();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultBolme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultCikarma();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultCarpma();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm2 = new Form1();
            frm2.Show();
        }
    }
}
