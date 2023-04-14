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
    public partial class DateCalculator : Form
    {
        public DateCalculator()
        {

            InitializeComponent();
        }
        static int HowOldAreU(int a, int b)
        {
            //Yıl Bilen
            return a - b;
        }
        static int HowOldAreU(int a)
        {
            //Yıl Bilmeyen
            return DateTime.Now.Year - a;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label4.Text = Convert.ToString(HowOldAreU(a, b));
            
        }

        private void DateCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(HowOldAreU(Convert.ToInt32(textBox3.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm2 = new Form1();
            frm2.Show();
        }
    }
}
