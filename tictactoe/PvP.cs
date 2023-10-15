using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PVP code here
namespace tictactoe
{
   

    public partial class PvP : Form
    {
        private Button[] buttons = new Button[9];
        
        

        public PvP()
        {
            InitializeComponent();
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            //Common click event per button
            for (int i = 0; i < buttons.Length; i++) {
                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i;
            }

        }

        private void handleButtonclick(object? sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show("Button "+clickedButton.Tag + " was clicked");
        }

        private void PvP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
