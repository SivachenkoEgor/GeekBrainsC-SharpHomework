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
    public partial class InputForm : Form
    {
        Game game;
        public InputForm()
        {
            InitializeComponent();
            game = new Game();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            game.CheckResult(Int32.Parse(txtbxInput.Text));
                       
        }
    }
}
