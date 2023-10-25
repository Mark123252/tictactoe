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
        private bool playerXTurn = true; // true for player X, false for player O
        private bool gameOver = false;
        private Random random = new Random();
        private int playerScore = 0;
        private int aiScore = 0;

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
            // Player starts the game
            playerXTurn = true;
        }
        private void handleButtonclick(object? sender, EventArgs e)
        {
            if (gameOver)
                return;

            Button clickedButton = (Button)sender;
            int buttonIndex = (int)clickedButton.Tag;

            if (clickedButton.Text == "")
            {
                if (playerXTurn)
                    clickedButton.Text = "X";
                else
                    clickedButton.Text = "O";

                // Disable the button after being clicked
                clickedButton.Enabled = false;

                playerXTurn = !playerXTurn; // Switch turns

                // Check for a win or a draw
                CheckGame();

                // AI's turn
                if (!gameOver && !playerXTurn)
                {
                    MakeAiMove();
                }
            }
        }
        private void MakeAiMove()
        {
            List<Button> emptyButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    emptyButtons.Add(button);
                }
            }

            if (emptyButtons.Count > 0)
            {
                int randomIndex = random.Next(emptyButtons.Count);
                Button aiButton = emptyButtons[randomIndex];
                aiButton.Text = "O";
                aiButton.Enabled = false;

                playerXTurn = true; // Switch back to the player's turn

                // Check for a win or a draw
                CheckGame();
            }

        }

        private void CheckGame()
        {
            if (CheckForWinner("X"))
            {
                MessageBox.Show("Player X wins!");
                playerScore++; // Increment player's score
                textBox1.Text = playerScore.ToString(); // Update the player's score TextBox
                gameOver = true;
            }
            else if (CheckForWinner("O"))
            {
                MessageBox.Show("Player O (AI) wins!");
                aiScore++; // Increment AI's score
                textBox2.Text = aiScore.ToString(); // Update the AI's score TextBox
                gameOver = true;
            }
            else if (AllButtonsClicked())
            {
                MessageBox.Show("It's a draw!");
                gameOver = true;
            }
        }
        private bool CheckForWinner(string player)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i * 3].Text == player && buttons[i * 3 + 1].Text == player && buttons[i * 3 + 2].Text == player)
                    return true;
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text == player && buttons[i + 3].Text == player && buttons[i + 6].Text == player)
                    return true;
            }

            // Check diagonals
            if ((buttons[0].Text == player && buttons[4].Text == player && buttons[8].Text == player) ||
                (buttons[2].Text == player && buttons[4].Text == player && buttons[6].Text == player))
            {
                return true;
            }

            return false;
        }
        private bool AllButtonsClicked()
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

        private void Reset(object sender, EventArgs e)
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }

            playerXTurn = true; // Reset the turn to the player
            gameOver = false; // Reset the game state
        }

        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the game?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResetScore(object sender, EventArgs e)
        {
            playerScore = 0;
            aiScore = 0;
            textBox1.Text = playerScore.ToString();
            textBox2.Text = aiScore.ToString();
        }
    }


}

