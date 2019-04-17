using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAI
{
    public partial class Form1 : Form
    {

        public enum Player // used to control player symbols
        {
            X, O
        }

        Player currentPlayer; // calls player class
        List<Button> buttons; // list of buttons
        Random rand = new Random(); // random num gen
        int playerWins = 0; // initialize wins to 0
        int computerWins = 0; // initialize wins to 0

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // check which button was clicked
            currentPlayer = Player.X; // set currentPLayer to x
            button.Text = currentPlayer.ToString(); // change button to x's
            button.Enabled = false; // make it so they cant click it again
            button.BackColor = System.Drawing.Color.Cyan; // change background color of the button
            buttons.Remove(button); // remove button from our list so computer knows not to use it
            Check(); // check for a winning move
            Computermoves.Start(); // starts times for computer
        }

        private void Computermove(object sender, EventArgs e)
        {
            if(buttons.Count > 0) // only try to click something if there are buttons to click!
            {
                int index = rand.Next(buttons.Count); // create rand number between the available buttons
                buttons[index].Enabled = false;
                currentPlayer = Player.O; // set player to O
                buttons[index].Text = currentPlayer.ToString(); // set the text to O on button
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; // change background color
                buttons.RemoveAt(index); // remove this button from list
                Check(); // check for a winning move
                Computermoves.Stop(); // stops computer timer
            }
        }

      private void restartGame(object sender, EventArgs e)
        {
            resetGame();
            playerWins = 0; // sets all win counters back to 0
            computerWins = 0;
            PlayerWins1.Text = "Player Wins: " + playerWins;
            Computerwins1.Text = "Computer Wins: " + computerWins;
        }

        private void loadbuttons() // load buttons into list
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls) // reset game board (all buttons with a tag = Play)
            {
                if (X is Button && X.Tag == "Play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "";
                    ((Button)X).BackColor = default(Color);
                }
            }
            loadbuttons();            
        }

        private void Check()
        {
            //if player wins
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                Computermoves.Stop();
                MessageBox.Show("You won!");
                playerWins++;
                PlayerWins1.Text = "Player Wins: " + playerWins;
                resetGame();
            }

            //if comp wins
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                Computermoves.Stop();
                MessageBox.Show("Computer won!");
                computerWins++;
                Computerwins1.Text = "Computer Wins: " + computerWins;
                resetGame();
            }

        }
    }
}
