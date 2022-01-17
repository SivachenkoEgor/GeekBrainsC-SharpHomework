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
    public partial class Game : Form
    {
        // б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        // Игрок должен получить это число за минимальное количество ходов.
        private int rndNumber;
        Stack<int> StackField;

        public int RndNumber
        {
            get { return rndNumber; }
            set { rndNumber = value; }
        }




        public Game()
        {
            InitializeComponent();
            StackField = new Stack<int>();
            btnIncrement.Text = "+1";
            btnMultiByTwo.Text = "x2";
            btnReset.Text = "Reset";
            lblNumber.Text = "0";
            lblInputCount.Text = "0";
            btnUndo.Text = "Undo";
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {

            UndoStacker(StackField, int.Parse(lblNumber.Text));
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblInputCount.Text = (int.Parse(lblInputCount.Text) + 1).ToString();
            Check_Win(this.RndNumber, int.Parse(lblNumber.Text));


        }

        private void btnMultiByTwo_Click(object sender, EventArgs e)
        {
            UndoStacker(StackField, int.Parse(lblNumber.Text));
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblInputCount.Text = (int.Parse(lblInputCount.Text) + 1).ToString();
            Check_Win(this.RndNumber, int.Parse(lblNumber.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UndoStacker(StackField, int.Parse(lblNumber.Text));
            lblNumber.Text = "1";
            lblInputCount.Text = (int.Parse(lblInputCount.Text) + 1).ToString();
            Check_Win(this.RndNumber, int.Parse(lblNumber.Text));
        }

        private void Check_Win(int rnd, int count)
        {
            if (rnd == count)
                MessageBox.Show("You won!");

        }

        private void UndoStacker(Stack<int> stacker, int number)
        {

            stacker.Push(number);



        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (StackField.Count != 0)
            {
                lblNumber.Text = StackField.Peek().ToString();
                StackField.Pop();
            }
            lblInputCount.Text = (int.Parse(lblInputCount.Text) + 1).ToString();
        }
    }
}
