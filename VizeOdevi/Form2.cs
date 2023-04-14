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
    public partial class Form2 : Form
    {
        string[] avatarNamesBoysNGirls = new string[100];
        public Form2()
        {
            avatarNamesBoysNGirls[0] = "Bang";
            avatarNamesBoysNGirls[1] = "Chang";
            avatarNamesBoysNGirls[2] = "Fa";
            avatarNamesBoysNGirls[3] = "Feng";
            avatarNamesBoysNGirls[4] = "Fu";
            avatarNamesBoysNGirls[5] = "Hao";
            avatarNamesBoysNGirls[6] = "Huang Fu";
            avatarNamesBoysNGirls[7] = "Hung";
            avatarNamesBoysNGirls[8] = "Jiao-long";
            avatarNamesBoysNGirls[9] = "Kong";
            avatarNamesBoysNGirls[10] = "Aito";
            avatarNamesBoysNGirls[11] = "Akihito";
            avatarNamesBoysNGirls[12] = "Akimitsu";
            avatarNamesBoysNGirls[13] = "Akio";
            avatarNamesBoysNGirls[14] = "Arata";
            avatarNamesBoysNGirls[15] = "Atsuo";
            avatarNamesBoysNGirls[16] = "Arashi";
            avatarNamesBoysNGirls[17] = "Daichi";
            avatarNamesBoysNGirls[18] = "Daiki";
            avatarNamesBoysNGirls[19] = "Etsuo";
            avatarNamesBoysNGirls[20] = "Fuyuki";
            avatarNamesBoysNGirls[21] = "Goro";
            avatarNamesBoysNGirls[22] = "Hayao";
            avatarNamesBoysNGirls[23] = "Jiro";
            avatarNamesBoysNGirls[24] = "Kazuma";
            avatarNamesBoysNGirls[25] = "Fing";
            avatarNamesBoysNGirls[26] = "Daang";
            avatarNamesBoysNGirls[27] = "Fayako";
            avatarNamesBoysNGirls[28] = "Lio";
            avatarNamesBoysNGirls[29] = "Sakaro";
            avatarNamesBoysNGirls[30] = "Makaho";
            avatarNamesBoysNGirls[31] = "Receppe";
            avatarNamesBoysNGirls[32] = "Kamiru";
            avatarNamesBoysNGirls[33] = "Ronin";
            avatarNamesBoysNGirls[34] = "Seu Le";
            avatarNamesBoysNGirls[35] = "Dao";
            avatarNamesBoysNGirls[36] = "Kehao";
            avatarNamesBoysNGirls[37] = "Takato";
            avatarNamesBoysNGirls[38] = "Foro";
            avatarNamesBoysNGirls[39] = "Naksu";
            avatarNamesBoysNGirls[40] = "Kora";
            avatarNamesBoysNGirls[41] = "Deka";
            avatarNamesBoysNGirls[42] = "Katsao";
            avatarNamesBoysNGirls[43] = "Fung";
            avatarNamesBoysNGirls[44] = "Tong";
            avatarNamesBoysNGirls[45] = "Rito";
            avatarNamesBoysNGirls[46] = "Kulo";
            avatarNamesBoysNGirls[47] = "Tekato";
            avatarNamesBoysNGirls[48] = "Tokato";
            avatarNamesBoysNGirls[49] = "Seng";
            avatarNamesBoysNGirls[50] = "Kalon";
            avatarNamesBoysNGirls[51] = "Ki";
            avatarNamesBoysNGirls[52] = "Kuemira";
            avatarNamesBoysNGirls[53] = "Suero";
            avatarNamesBoysNGirls[54] = "Yeh";
            avatarNamesBoysNGirls[55] = "Tunnori";
            avatarNamesBoysNGirls[56] = "Zoarek";
            avatarNamesBoysNGirls[57] = "Mokoyan";
            avatarNamesBoysNGirls[58] = "Uehak";
            avatarNamesBoysNGirls[59] = "Hiatado";
            avatarNamesBoysNGirls[60] = "Soavre";
            avatarNamesBoysNGirls[61] = "Kano";
            avatarNamesBoysNGirls[62] = "Mai";
            avatarNamesBoysNGirls[63] = "Latuo";
            avatarNamesBoysNGirls[64] = "Yemeyi";
            avatarNamesBoysNGirls[65] = "Pine";
            avatarNamesBoysNGirls[66] = "Zurlo";
            avatarNamesBoysNGirls[67] = "Nokoq";
            avatarNamesBoysNGirls[68] = "Ti";
            avatarNamesBoysNGirls[69] = "Soreni";
            avatarNamesBoysNGirls[70] = "Roshor";
            avatarNamesBoysNGirls[71] = "Veduq";
            avatarNamesBoysNGirls[72] = "Jinora";
            avatarNamesBoysNGirls[73] = "Hiallak";
            avatarNamesBoysNGirls[74] = "Mita";
            avatarNamesBoysNGirls[75] = "Laka";
            avatarNamesBoysNGirls[76] = "Fiyu";
            avatarNamesBoysNGirls[77] = "Fimu";
            avatarNamesBoysNGirls[78] = "Gamuor";
            avatarNamesBoysNGirls[79] = "Molloyu";
            avatarNamesBoysNGirls[80] = "Xaneng";
            avatarNamesBoysNGirls[81] = "Lia";
            avatarNamesBoysNGirls[82] = "Hueh";
            avatarNamesBoysNGirls[83] = "Loyodi";
            avatarNamesBoysNGirls[84] = "Lehan";
            avatarNamesBoysNGirls[85] = "Halrok";
            avatarNamesBoysNGirls[86] = "Chong";
            avatarNamesBoysNGirls[87] = "Chimin";
            avatarNamesBoysNGirls[88] = "Todur";
            avatarNamesBoysNGirls[89] = "Tero";
            avatarNamesBoysNGirls[90] = "Patadeq";
            avatarNamesBoysNGirls[91] = "Kayuni";
            avatarNamesBoysNGirls[92] = "Mi Punaa";
            avatarNamesBoysNGirls[93] = "Rilre";
            avatarNamesBoysNGirls[94] = "Asami Sato";
            avatarNamesBoysNGirls[95] = "Sayori";
            avatarNamesBoysNGirls[96] = "Osoru";
            avatarNamesBoysNGirls[97] = "Le Muhan";
            avatarNamesBoysNGirls[98] = "Konilar";
            avatarNamesBoysNGirls[99] = "Mahayi";

            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int randomNumber = Convert.ToInt32(txtRndNumber.Text);

            if (randomNumber < 49)
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 50);
                label2.Text = avatarNamesBoysNGirls[i];
            }
            else if (randomNumber < 100 && randomNumber > 49)
            {
                Random rnd = new Random();
                int i = rnd.Next(50, 100);
                label2.Text = avatarNamesBoysNGirls[i];
            }
            else
            {
                label2.Text = "Between 0-99";
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
