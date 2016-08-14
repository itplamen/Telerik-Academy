namespace _04.Tic_Tac_Toe
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Index : Page
    {
        private IList<Button> buttons;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.buttons = new List<Button>()
            {
                this.ButtonOne, this.ButtonTwo, this.ButtonThree,
                this.ButtonFour, this.ButtonFive, this.ButtonSix,
                this.ButtonSeven, this.ButtonEight, this.ButtonNine
            };
        }

        protected void OnUserButtonClick(object sender, EventArgs e)
        {
            var selectedButton = (sender as Button);

            if (selectedButton.Text != "O")
            {
                selectedButton.Text = "X";
                selectedButton.ForeColor = Color.Black;
                selectedButton.Enabled = false;

                if (this.IsWon("X"))
                {
                    this.PlayerScores.Text = (int.Parse(this.PlayerScores.Text) + 1).ToString();
                    this.GameBoard.Enabled = false;
                    this.WhoWonTheGameLabel.Text = "Player Won The Game!";
                    this.WhoWonTheGameLabel.ForeColor = Color.Green;
                }
                else
                {
                    this.ComputerMove();
                }
            }
        }

        protected void OnNewGameClick(object sender, EventArgs e)
        {
            this.GameBoard.Enabled = true;
            this.WhoWonTheGameLabel.Text = string.Empty;

            foreach (var button in this.buttons)
            {
                button.Text = " ";
                button.Enabled = true;
            }
        }

        private void ComputerMove()
        {
            Random randomButton = new Random();
            int index = randomButton.Next(0, this.buttons.Count - 1);

            if (this.AreThereAvailableBlocks())
            {
                while (true)
                {
                    if (this.buttons[index].Text != "X" && this.buttons[index].Text != "O")
                    {
                        this.buttons[index].Text = "O";
                        this.buttons[index].ForeColor = Color.Gray;
                        this.buttons[index].Enabled = false;
                        break;
                    }

                    index = randomButton.Next(0, this.buttons.Count - 1);
                }

                if (this.IsWon("O"))
                {
                    this.ComputerScores.Text = (int.Parse(this.ComputerScores.Text) + 1).ToString();
                    this.GameBoard.Enabled = false;
                    this.WhoWonTheGameLabel.Text = "Computer Won The Game!";
                    this.WhoWonTheGameLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                this.WhoWonTheGameLabel.Text = "No one Won The Game!";
                this.WhoWonTheGameLabel.ForeColor = Color.Black;
            }
        } 

        private bool IsWon(string symbol)
        {
            // Check horizontally
            if ((this.ButtonOne.Text == this.ButtonTwo.Text && this.ButtonOne.Text == this.ButtonThree.Text && this.ButtonOne.Text == symbol) ||
                (this.ButtonFour.Text == this.ButtonFive.Text && this.ButtonFour.Text == this.ButtonSix.Text && this.ButtonFour.Text == symbol) ||
                (this.ButtonSeven.Text == this.ButtonEight.Text && this.ButtonSeven.Text == this.ButtonNine.Text && this.ButtonSeven.Text == symbol))
            {
                return true;
            }
            // Check vertically
            else if ((this.ButtonOne.Text == this.ButtonFour.Text && this.ButtonOne.Text == this.ButtonSeven.Text && this.ButtonOne.Text == symbol) ||
                    (this.ButtonTwo.Text == this.ButtonFive.Text && this.ButtonTwo.Text == this.ButtonEight.Text && this.ButtonTwo.Text == symbol) ||
                    (this.ButtonThree.Text == this.ButtonSix.Text && this.ButtonThree.Text == this.ButtonNine.Text && this.ButtonThree.Text == symbol))
            {
                return true;
            }
            // Check diagonally
            else if ((this.ButtonOne.Text == this.ButtonFive.Text && this.ButtonOne.Text == this.ButtonNine.Text && this.ButtonOne.Text == symbol) ||
                    (this.ButtonThree.Text == this.ButtonFive.Text && this.ButtonThree.Text == this.ButtonSeven.Text && this.ButtonThree.Text == symbol))
            {
                return true;
            }

            return false;
        }

        private bool AreThereAvailableBlocks()
        {
            foreach (var button in this.buttons)
            {
                if (button.Text != "X" && button.Text != "O")
                {
                    return true;
                }
            }

            return false;
        }
    }
}