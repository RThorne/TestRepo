using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        int taskai = 0;
        int high = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pasirenkam lygi
            int max = 3;
            if (level.SelectedIndex == 0)
            {
                max = 3;
            }
            else if (level.SelectedIndex == 1)
            {
                max = 11;
            }
            else if (level.SelectedIndex == 2)
            {
                max = 36;
            }

            // Tikrinam userio inputa
            if (input.Text.Length == 0)
            {
                MessageBox.Show("Ivesk teksta");
                return;
            }
            int usr = Int32.Parse(input.Text);

            if (usr < 1 || usr >= max)
            {
                MessageBox.Show("Blogas ivedimas");
            }

            // Zaidimas
            Random rnd = new Random();
            int chk = rnd.Next(1, max);

            if (chk == usr)
            {
                taskai++;
            }
            else
            {
                taskai--;
            }

            if (taskai > high)
            {
                high = taskai;
            }

            pcguess.Text = "Kompiuterio sk: " + chk.ToString();
            score.Text = "Taskai: " + taskai.ToString();
            File.WriteAllText("high.txt", high.ToString());
            highscore.Text = "Geriausias rez: " + high.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string a = File.ReadAllText("high.txt");
                high = Int32.Parse(a);
            }
            catch (Exception ex)
            {
                high = 0;
            }
            highscore.Text = "Geriausias rez: " + high.ToString();
        }
    }
}
