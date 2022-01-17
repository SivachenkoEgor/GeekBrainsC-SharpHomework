using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_7._1
{
    public partial class Menu : Form
    {
        int rndNumber;
        public Menu()
        {
            InitializeComponent();
            Random rnd = new Random();
            rndNumber = rnd.Next(0, 1000);
            btnYes.Text = "Play";
            btnQuit.Text = "Quit";
            lblQuestion.Text = $"Wanna play a game?\nYou have to hit number {rndNumber}";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gameForm = new Game();
            gameForm.RndNumber = this.rndNumber;
            gameForm.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
