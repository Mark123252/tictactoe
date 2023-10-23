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
    public partial class PvP : Form
    {
        private Button[] buttons = new Button[9];
        private bool isPlayerOneTurn = true;

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

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i;
            }
        }

        private void handleButtonclick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonIndex = (int)clickedButton.Tag;

            if (clickedButton.Text != "" || CheckForWinner()) return;

            if (isPlayerOneTurn)
            {
                clickedButton.Text = "X";
            }
            else
            {
                clickedButton.Text = "O";
            }

            isPlayerOneTurn = !isPlayerOneTurn;

            if (CheckForWinner())
            {
                string winner = isPlayerOneTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins!");
                ResetGame();
            }
            else if (IsBoardFull())
            {
                MessageBox.Show("It's a draw!");
                ResetGame();
            }
        }

        private bool CheckForWinner()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i * 3].Text != "" && buttons[i * 3].Text == buttons[i * 3 + 1].Text && buttons[i * 3].Text == buttons[i * 3 + 2].Text)
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text != "" && buttons[i].Text == buttons[i + 3].Text && buttons[i].Text == buttons[i + 6].Text)
                {
                    return true;
                }
            }

            // Check diagonals
            if (buttons[0].Text != "" && buttons[0].Text == buttons[4].Text && buttons[0].Text == buttons[8].Text)
            {
                return true;
            }
            if (buttons[2].Text != "" && buttons[2].Text == buttons[4].Text && buttons[2].Text == buttons[6].Text)
            {
                return true;
            }

            return false;
        }

        private bool IsBoardFull()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void ResetGame()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
            }

            isPlayerOneTurn = true;
        }
    }
}
