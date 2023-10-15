using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class PvAi : Form
    {
        private Button[] buttons = new Button[9];
        public PvAi()
        {
            InitializeComponent();
            buttons[0] = button10;
            buttons[1] = button11;
            buttons[2] = button12;
            buttons[3] = button13;
            buttons[4] = button14;
            buttons[5] = button15;
            buttons[6] = button16;
            buttons[7] = button17;
            buttons[8] = button18;
            //Common click event per button
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i;
            }

        }
        private void handleButtonclick(object? sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show("Button " + clickedButton.Tag + " was clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
