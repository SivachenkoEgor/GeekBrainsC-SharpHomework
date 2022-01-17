using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_7._2
{
    public partial class Game : Form
    {
        int rndNumber;
        
        public Game()
        {
            InitializeComponent();
            Random rnd = new Random();
            rndNumber = rnd.Next(0, 100);
            
        }
        public void CheckResult(int input)
        {
            if (input < rndNumber)
            {

                MessageBox.Show("Загаданное число больше!"); 
                lblStatement.Text = "Загаданное число больше!!";
            }
            else if (input > rndNumber)
            {

                MessageBox.Show("Загаданное число меньше!");
                lblStatement.Text = "Загаданное число меньше!";
            }
            else if (input == rndNumber)
            {
                MessageBox.Show("Победа!");
            }



        }


    }
}
