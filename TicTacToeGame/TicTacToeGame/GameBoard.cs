using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GameBoard : Form
    {
        // public fields to indicate turn of player, and who won the game
        public static int playerTurn;
        public static bool playerOneWin;
        public static bool playerTwoWin;
        public static bool gameIsDraw;

        public GameBoard()
        {
            InitializeComponent();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = playerTurn % 2 == 0 ? "X" : "O";
            playerTurn++;

            b.Enabled = false;

            CheckWinner();
        }
       
        private void CheckWinner()
        {
            CheckDiagonal();
            CheckHorizontal();
            CheckVertical();

            if (playerOneWin == true) { DisableButtons(); MessageBox.Show("Player One Wins!"); }
            else if (playerTwoWin == true) { DisableButtons(); MessageBox.Show("Player Two Wins!"); }
            else if (gameIsDraw == true) { DisableButtons(); MessageBox.Show("Game is a draw!"); }

        }

        private void CheckDiagonal()
        {
            if ((A1.Text == B2.Text) && (A1.Text == C3.Text) && (!A1.Enabled))
            {
                playerOneWin = A1.Text == "X" ? true : false;
                playerTwoWin = A1.Text == "O" ? true : false;
            }
            else if ((A3.Text == B2.Text) && (A3.Text == C1.Text) && (!C1.Enabled))
            {
                playerOneWin = A3.Text == "X" ? true : false;
                playerTwoWin = A3.Text == "O" ? true : false;
            }
            else if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != ""
                                   && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                gameIsDraw = true;
            }
        }

        private void CheckHorizontal()
        {
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
            else if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != ""
                                   && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                gameIsDraw = true;
            }
        }

        private void CheckVertical()
        {
            if ((A1.Text == B1.Text) && (A1.Text == C1.Text) && (!A1.Enabled))
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
            else if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != ""
                                   && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                gameIsDraw = true;
            }
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            playerOneWin = false;
            playerTwoWin = false;
            gameIsDraw = false;
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Cristian Canedo", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerOneWin = false;
            playerTwoWin = false;
            gameIsDraw = false;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
        
    }
}
