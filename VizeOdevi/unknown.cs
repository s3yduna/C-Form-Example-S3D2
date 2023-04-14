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
    public partial class unknown : Form
    {
        public unknown()
        {
            InitializeComponent();
        }

        private void unknown_Load(object sender, EventArgs e)
        {

        }

        static long Factoriel (int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factoriel(number - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Factoriel(Convert.ToInt32(textBox1.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm2 = new Form1();
            frm2.Show();
        }
    }
}
