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

        char who = 'X';
        short movement = 0;
        int playerOneScore = 0;
        int playerTwoScore = 0;

        public PvP()
        {
            InitializeComponent();
            buttons[0] = B1;
            buttons[1] = B2;
            buttons[2] = B3;
            buttons[3] = B4;
            buttons[4] = B5;
            buttons[5] = B6;
            buttons[6] = B7;
            buttons[7] = B8;
            buttons[8] = B9;

            //Common click event per button
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i;
            }

            TB1.Text = playerOneScore.ToString();
            TB2.Text = playerTwoScore.ToString();

        }

        private void handleButtonclick(object? sender, EventArgs e)
        {
            movement++;
        }

        private void PvP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.White;
            if (who == 'X')
            {
                bt.Text = "X";
                if ((B1.Text == B2.Text && B2.Text == B3.Text && B2.Text != "") ||
                    (B4.Text == B5.Text && B5.Text == B6.Text && B5.Text != "") ||
                    (B7.Text == B8.Text && B8.Text == B9.Text && B8.Text != "") ||
                    (B1.Text == B4.Text && B4.Text == B7.Text && B4.Text != "") ||
                    (B2.Text == B5.Text && B5.Text == B8.Text && B5.Text != "") ||
                    (B3.Text == B6.Text && B6.Text == B9.Text && B6.Text != "") ||
                    (B1.Text == B5.Text && B5.Text == B9.Text && B5.Text != "") ||
                    (B3.Text == B5.Text && B5.Text == B7.Text && B5.Text != ""))
                {
                    MessageBox.Show($"Player One (X) wins!");
                    playerOneScore++;
                    TB1.Text = playerOneScore.ToString();
                    panel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw !!!");
                }
                who = 'O';

            }
            else if (who == 'O')
            {
                bt.Text = "O";
                if ((B1.Text == B2.Text && B2.Text == B3.Text && B2.Text != "") ||
                    (B4.Text == B5.Text && B5.Text == B6.Text && B5.Text != "") ||
                    (B7.Text == B8.Text && B8.Text == B9.Text && B8.Text != "") ||
                    (B1.Text == B4.Text && B4.Text == B7.Text && B4.Text != "") ||
                    (B2.Text == B5.Text && B5.Text == B8.Text && B5.Text != "") ||
                    (B3.Text == B6.Text && B6.Text == B9.Text && B6.Text != "") ||
                    (B1.Text == B5.Text && B5.Text == B9.Text && B5.Text != "") ||
                    (B3.Text == B5.Text && B5.Text == B7.Text && B5.Text != ""))
                {
                    MessageBox.Show($"Player Two (O) wins!");
                    playerTwoScore++;
                    TB2.Text = playerTwoScore.ToString();
                    panel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw !!!");
                }
                who = 'X';
            }
        }

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void TB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void B10_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
                button.BackColor = SystemColors.Control;
            }

            who = 'X';
            movement = 0;
            panel1.Enabled = true;

        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B11_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application

        }

        private void B12_Click(object sender, EventArgs e)
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            TB1.Text = playerOneScore.ToString();
            TB2.Text = playerTwoScore.ToString();
        }
    }
}
