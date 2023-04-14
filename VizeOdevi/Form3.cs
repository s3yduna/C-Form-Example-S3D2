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
    public partial class Form3 : Form
    {
        int a, b;
        public Form3()
        {
            
            Random rowRnd = new Random();
            Random colRnd = new Random();
            a = rowRnd.Next(1, 3);
            b = colRnd.Next(1, 6);
            int[,] diziWhereAmI = new int[a, b];
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm2 = new Form1();
            frm2.Show();
        }

        //----------------------------------------------------


        public void button1_Click(object sender, EventArgs e)
        {
            

            int userRow = Convert.ToInt32(txtRow.Text);
            int userCol = Convert.ToInt32(txtCol.Text);

            if (userRow == a && userCol == b)
            {
                label5.Text = "Congrats brada, u find ME!!";
            }
            else if (userRow != a && userCol == b)
            {
                label5.Text = "U Find Column!! Try Again for ROW ";
            }
            else if (userRow == a && userCol != b)
            {
                label5.Text = "U Find Row!! Try Again for COLUMN";
            }
            else
            {
                label5.Text = "Try Again!";
            }


        }
        
    }
}
