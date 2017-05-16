using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        
        private int playerTurn; // variable to determine player turn
        private bool playerOneWin; // variable to determine if player one wins
        private bool playerTwoWin; // variable to determine if player two wins
        private bool gameIsDraw; // variable to determine if game is a draw

        public Form1()
        {
            InitializeComponent();
            
            // Initialize all variables in constructor
            playerTurn = 0;
            playerOneWin = false;
            playerTwoWin = false;
            gameIsDraw = false;
        }

        // Event handler to handle a button click
        private void btnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender; // Creating a new instance of Button and
                                        // casting the sender paramater as Button
            b.Text = playerTurn % 2 == 0 ? "X" : "O"; // Writes X or O depending on playerTurn variable
            b.Enabled = false; // Disables button that was clicked
            playerTurn++; // Increments playerTurn variable to indicate next turn 
            CheckWinner(); // Checks buttons for winner

        }


private void CheckWinner()
        {
            // Check Horizontal buttons and check if button is not enabled
            if ((A1.Text == A2.Text) && (A1.Text == A3.Text) && (!A1.Enabled))
            {
                playerOneWin = A1.Text == "X" ? true : false;
                playerTwoWin = A1.Text == "O" ? true : false;
            }
            else if ((B1.Text == B2.Text) && (B1.Text == B3.Text) && (!B1.Enabled))
            {
                playerOneWin = B1.Text == "X" ? true : false;
                playerTwoWin = B1.Text == "O" ? true : false;
            }
            else if ((C1.Text == C2.Text) && (C1.Text == C3.Text) && (!C1.Enabled))
            {
                playerOneWin = C1.Text == "X" ? true : false;
                playerTwoWin = C1.Text == "O" ? true : false;
            }

            // Check Vertical buttons and check if button is not enabled
            else if ((A1.Text == B1.Text) && (A1.Text == C1.Text) && (!A1.Enabled))
            {
                playerOneWin = A1.Text == "X" ? true : false;
                playerTwoWin = A1.Text == "O" ? true : false;
            }
            else if ((A2.Text == B2.Text) && (A2.Text == C2.Text) && (!A2.Enabled))
            {
                playerOneWin = A2.Text == "X" ? true : false;
                playerTwoWin = A2.Text == "O" ? true : false;
            }
            else if ((A3.Text == B3.Text) && (A3.Text == C3.Text) && (!A3.Enabled))
            {
                playerOneWin = A3.Text == "X" ? true : false;
                playerTwoWin = A3.Text == "O" ? true : false;
            }

            // Check Diagonal buttons and check if button is not enabled
            else if ((A1.Text == B2.Text) && (A1.Text == C3.Text) && (!A1.Enabled))
            {
                playerOneWin = A1.Text == "X" ? true : false;
                playerTwoWin = A1.Text == "O" ? true : false;
            }
            else if ((A3.Text == B2.Text) && (A3.Text == C1.Text) && (!C1.Enabled))
            {
                playerOneWin = C1.Text == "X" ? true : false;
                playerTwoWin = C1.Text == "O" ? true : false;
            }
            else if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != ""
                                         && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                gameIsDraw = true;
            }

            // if-else-if statement to display winner message to screen
            if (playerOneWin)
            {
                DisableButtons();
                MessageBox.Show("Player One Wins!");
            }
            else if (playerTwoWin)
            {
                DisableButtons();
                MessageBox.Show("Player Two Wins!");
            }
            else if (gameIsDraw)
            {
                DisableButtons();
                MessageBox.Show("Game is a draw!");
            }
        }

        private void DisableButtons()
        {
            // Iterates through all controls
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c; // Cast control as new object instance of Button
                    b.Enabled = false; // Enables all buttons
                }
                catch { } // Catches and handles invalid cast exception
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Iterates through all controls
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c; // Cast control as new object instance of Button
                    b.Enabled = true; // Enables all buttons
                    b.Text = ""; // Clears button text of X and O
                }
                catch { } // Catches and handles invalid cast exception
            }

            playerOneWin = false;
            playerTwoWin = false;
            gameIsDraw = false;
            playerTurn = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Cristian Canedo", "About");
        }
    }
}
