using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Blackjack
{
    public partial class BlackjackForm : Form
    {
        #region Globals

        // Declare global variables for deck array and values, hand attributes, bank amount, etc.
        static Random _random = new Random();

        int[] deckAsInts = new int[52];
        int[] deckValues = {11,11,11,11, 10,10,10,10, 10,10,10,10, 10,10,10,10 ,10,10,10,10,
                           9,9,9,9, 8,8,8,8, 7,7,7,7 ,6,6,6,6, 5,5,5,5, 4,4,4,4, 3,3,3,3, 2,2,2,2};
        int nextCard;
        int playerHand;
        int houseHand;
        int pCardNumber;
        int hCardNumber;
        int pAces;
        int hAces;

        int houseLimit = 14;

        PictureBox[] playerCards = new PictureBox[8];
        PictureBox[] houseCards = new PictureBox[8];

        PictureBox cardBack = new PictureBox();
        int cardBackCount;

        double bet;
        double bankDouble;

        double houseBankDouble;

        int playerHiddenCard;
        int houseHiddenCard;

        // Used for toolbar to change settings
        int mouseY1;
        int mouseY2;
        int mouseX1;
        int mouseX2;
        int passCount;
        int levelSelectAllow;

        #endregion

        public BlackjackForm()
        {
            InitializeComponent();

            // Use toolbar to allow level adjustment and card back preference
            toolStripEnabler.Start();

            // Assign each card in the deck array a number value and then shuffle the deck
            for (int i = 0; i < 52; i++)
            {
                deckAsInts[i] = i + 1;
            }
            Shuffle(deckAsInts);
            
            // Initialize player and bank values
            resultLabel.Text = "";
            bankDouble = 300;
            bankTextBox.Text = bankDouble.ToString();

            houseBankDouble = 50;
            houseBankTextBox.Text = houseBankDouble.ToString();

            // Display opening House text
            houseOutputLabel.Visible = true;
            houseOutputLabel.Text = "Hey! So you wanna face off? \r\nI'll start off easy. How does $50 sound?";

            // Disable deal button and bet box while House text is visible
            dealButton.Enabled = false;
            betTextBox.ReadOnly = true;

            // Load card back and initialize Player and House cards to transparent
            cardBack.Load("classic-cards\\b1fv.png");

            playerCards[0] = playerCard1Picture;
            playerCards[1] = playerCard2Picture;
            playerCards[2] = playerCard3Picture;
            playerCards[3] = playerCard4Picture;
            playerCards[4] = playerCard5Picture;
            playerCards[5] = playerCard6Picture;
            playerCards[6] = playerCard7Picture;
            playerCards[7] = playerCard8Picture;

            houseCards[0] = houseCard1Picture;
            houseCards[1] = houseCard2Picture;
            houseCards[2] = houseCard3Picture;
            houseCards[3] = houseCard4Picture;
            houseCards[4] = houseCard5Picture;
            houseCards[5] = houseCard6Picture;
            houseCards[6] = houseCard7Picture;
            houseCards[7] = houseCard8Picture;

            // Initialize toolbar settings
            cardBackCount = 1;
            passCount = 0;
            levelSelectAllow = 0;

            level1.Checked = true;
        } // end BlackjackForm

        private void okButton_Click(object sender, EventArgs e)
        {
            // Close House text box and enable bet box and Hit and Stay buttons (though invisible)
            okButton.Visible = false;
            houseOutputLabel.Visible = false;
            dealButton.Enabled = true;
            hitButton.Enabled = true;
            stayButton.Enabled = true;
            betTextBox.ReadOnly = false;

            houseOutputLabel.SendToBack();
            Refresh();
            clearCards();
            houseOutputLabel.BringToFront();
            okButton.BringToFront();
        } // end okButton_Click

        private void dealButton_Click(object sender, EventArgs e)
        {
            // Set bet to invalid and exit method until proper input
            bool val = false;
            betValidation(ref val);
            if (val == false)
            { return; }

            // Hide Deal button
            dealButton.Visible = false;

            // Disable bet editing and clear text and previous round cards
            betTextBox.ReadOnly = true;
            resultLabel.Text = "";
            clearCards();

            // If more than 40 cards have been used, use Shuffle method to recycle deck
            if (nextCard > 40)
            {
                Shuffle(deckAsInts);
                nextCard = 0;
            }

            // Re-initialize hand total values, number of cards, and number of aces
            playerHand = 0;
            houseHand = 0;
            pCardNumber = -1;
            hCardNumber = -1;
            pAces = 0;
            hAces = 0;

            // Use Draw method to add 2 cards to Player hand
            // Increase cards drawn number and Player hand size
            drawCard(playerCards, ref playerHand, ref pAces, ref pCardNumber);
            playerCard2Picture.Image = cardBack.Image;
            playerCard2Picture.Visible = true;
            playerHiddenCard = deckAsInts[nextCard];
            nextCard++;
            pCardNumber++;
            Thread.Sleep(300);
            playerCard2Picture.Refresh();

            // Same process as above, but for House
            drawCard(houseCards, ref houseHand, ref hAces, ref hCardNumber);
            houseCard2Picture.Image = cardBack.Image;
            houseCard2Picture.Visible = true;
            houseHiddenCard = deckAsInts[nextCard];
            nextCard++;
            hCardNumber++;
            Thread.Sleep(300);
            houseCard2Picture.Refresh();

            // Reveal Player cards and add to hand total value
            playerCard2Picture.Load("classic-cards\\" + playerHiddenCard + ".png");
            if (deckValues[playerHiddenCard - 1] == 11)
            { pAces += 1; }
            playerHand += deckValues[playerHiddenCard - 1];
            Thread.Sleep(300);
            playerCard2Picture.Refresh();

            // Set Hit and Stay buttons to visible
            hitButton.Visible = true;
            stayButton.Visible = true;

            // Check for Player hand equaling 21 or more
            hand21();
        } // end dealButton_Click

        private void hitButton_Click(object sender, EventArgs e)
        {
            // Add card and value to Player hand
            drawCard(playerCards, ref playerHand, ref pAces, ref pCardNumber);

            // Check for Player hand equaling 21 or more
            hand21();
        } // end hitButton_Click

        private void stayButton_Click(object sender, EventArgs e)
        {
            // Hide the Hit and Stay buttons after Stay
            hitButton.Visible = false;
            stayButton.Visible = false;

            // Enable betting
            betTextBox.ReadOnly = false;

            // Display hidden House card and add value to House hand
            houseCard2Picture.Load("classic-cards\\" + houseHiddenCard + ".png");
            if (deckValues[houseHiddenCard - 1] == 11)
            { hAces += 1; }
            houseHand += deckValues[houseHiddenCard - 1];
            Thread.Sleep(300);
            houseCard2Picture.Refresh();

            Thread.Sleep(300); // Pause for effect

            // House begins the draw method until House limit is matched or passed
            while (houseHand < houseLimit)
            {
                drawCard(houseCards, ref houseHand, ref hAces, ref hCardNumber);
            }

            // Compare House and Player hands
            result();
        } // end stayButton_Click

        #region Additional methods

        public void result()
        {
            // Set Deal button to visible
            dealButton.Visible = true;

            // If House hand total exceeds 21, check for aces and change values to 1 (from 11)
            if (houseHand > 21)
            {
                if (hAces > 0)
                {
                    while (hAces > 0 && houseHand > 21)
                    {
                        hAces--;
                        houseHand -= 10;

                        while (houseHand < houseLimit)
                        {
                            drawCard(houseCards, ref houseHand, ref hAces, ref hCardNumber);
                        }
                    }
                }
                // Otherwise, House busts
                else
                {
                    resultLabel.Text = "House bust!";
                    houseBankDouble -= bet;
                    houseBankTextBox.Text = houseBankDouble.ToString();

                    // Check for House loss (and if so, increase level)
                    nextLevel();
                    return;
                }
            }
            // If round tied, no effects and move to next round
            if (playerHand == houseHand)
            {
                resultLabel.Text = "Round pushed.";
                return;
            }
            // If player wins, subtract bet amount from House bank
            if (playerHand > houseHand)
            {
                resultLabel.Text = "You won!";
                houseBankDouble -= bet;
                houseBankTextBox.Text = houseBankDouble.ToString();

                // Check for House loss (and if so, increase level)
                nextLevel();
                return;
            }
            // If House wins, subtract amount from Player bank
            if (playerHand < houseHand)
            {
                resultLabel.Text = "You lost...";
                bankDouble -= bet;
                bankTextBox.Text = bankDouble.ToString();
                
                // Check for Player loss
                restart();
            }
        } // end result

        public void hand21()
        {
            // If Player hand exceeds 21, check for aces and change their values according
            // If no aces are present and hand still exceeds 21, Player busts
            if (playerHand > 21)
            {
                while (pAces > 0 && playerHand > 21)
                {
                    pAces--;
                    playerHand -= 10;
                    if (playerHand < 21)
                    { return; }
                }
                hitButton.Visible = false;
                stayButton.Visible = false;
                dealButton.Visible = true;

                resultLabel.Text = "Bust!";
                bankDouble -= bet;
                bankTextBox.Text = bankDouble.ToString();

                betTextBox.ReadOnly = false;

                restart();
            }

            // If Player hand equals 21, automatically win the round
            if (playerHand == 21)
            {
                hitButton.Visible = false;
                stayButton.Visible = false;
                dealButton.Visible = true;

                resultLabel.Text = "Blackjack!";
                houseBankDouble -= bet;
                houseBankTextBox.Text = houseBankDouble.ToString();

                betTextBox.ReadOnly = false;
                nextLevel();
            }
        } // end hand21

        public void drawCard(PictureBox[] cards, ref int hand, ref int aces, ref int cardNumber)
        {
            cardNumber++;

            cards[cardNumber].Load("classic-cards\\" + deckAsInts[nextCard] + ".png");
            cards[cardNumber].Visible = true;
            if (deckValues[deckAsInts[nextCard] - 1] == 11)
            { aces += 1; }
            hand += deckValues[deckAsInts[nextCard] - 1];
            nextCard++;

            Thread.Sleep(300);
            cards[cardNumber].Refresh();

            if (cardNumber == 7)
            {
                hitButton.Enabled = false;
            }

        } // end drawCard

        public void clearCards()
        {
            for (int i = 3; i > -1; i--)
            {
                playerCards[i].Visible = false;
                playerCards[i + 4].Visible = false;
                houseCards[i].Visible = false;
                houseCards[i + 4].Visible = false;

                Thread.Sleep(50);

                playerCards[i].Refresh();
                playerCards[i + 4].Refresh();
                houseCards[i].Refresh();
                houseCards[i + 4].Refresh();
            }
        } // end clearCards

        public bool betValidation(ref bool validation)
        {
            // Test bet for validity
            if (betTextBox.Text == "" || betTextBox.Text == "0")
            {
                resultLabel.Text = "No bet, no game.";
                return validation = false;
            }

            if (!double.TryParse(betTextBox.Text, out bet))
            {
                resultLabel.Text = "WHAT are you trying to bet with?";
                return validation = false;
            }

            if (bet < 0)
            {
                resultLabel.Text = "Do you really think I'll give you free money?";
                return validation = false;
            }
            if (bet > bankDouble)
            {
                resultLabel.Text = "Look at your bank before you bet...";
                return validation = false;
            }
            if (bet > houseBankDouble)
            {
                resultLabel.Text = "I can't match that!";
                return validation = false;
            }

            if (bet % 1 != 0)
            {
                resultLabel.Text = "I'd rather not use change.";
                return validation = false;
            }
            return validation = true;
        } // end betValidation

        public void restart()
        {
            if(bankDouble == 0 || houseBankDouble == 0)
            {
                DialogResult answer = MessageBox.Show("Do you want to play again?", "You're bank is empty...", MessageBoxButtons.YesNo);
                string answer2 = answer.ToString();
                if (answer2 == "Yes")
                {
                    dealButton.Enabled = false;
                    hitButton.Enabled = false;
                    stayButton.Enabled = false;

                    houseOutputLabel.Visible = true;
                    okButton.Visible = true;
                    houseOutputLabel.Text = "Hey! So you wanna face off? \r\nI'll go easy first. How does $50 for me sound?";
                    houseLimit = 14;

                    resultLabel.Text = "";
                    betTextBox.Text = "";
                    betTextBox.ReadOnly = true;
                    clearCards();

                    bankDouble = 300;
                    bankTextBox.Text = bankDouble.ToString();

                    houseBankDouble = 50;
                    houseBankTextBox.Text = houseBankDouble.ToString();
                    return;
                }
                else
                { Application.Exit(); }
            }
        } // end restart

        /// <summary>
        /// Shuffle the array.
        /// </summary>
        /// <typeparam name="T">Array element type.</typeparam>
        /// <param name="array">Array to shuffle.</param>
        public static void Shuffle<T>(T[] array)
        {
            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                // Pick random element to swap.
                int j = random.Next(i); // 0 <= j <= i-1
                // Swap.
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        } // end Shuffle

        public void nextLevel()
        {
            if(houseBankDouble == 0 || levelSelectAllow == 1)
            {
                if (levelSelectAllow == 1)
                { bankDouble = 300;
                bankTextBox.Text = bankDouble.ToString(); }
                levelSelectAllow = 0;

                houseOutputLabel.Visible = true;
                okButton.Visible = true;
                betTextBox.ReadOnly = true;
                dealButton.Enabled = false;
                dealButton.Visible = true;
                hitButton.Visible = false;
                stayButton.Visible = false;

                level1.Checked = false;
                level2.Checked = false;
                level3.Checked = false;
                level4.Checked = false;
                level5.Checked = false;

                houseLimit++;
                if(houseLimit == 15)
                {
                    houseOutputLabel.Text = "Oh, so you won that match, eh? \r\nThis time'll be a little harder.";
                    houseBankDouble = 100;
                    level2.Checked = true;
                }
                if (houseLimit == 16)
                {
                    houseOutputLabel.Text = "Wow, you beat me another time.  \r\nI'll treat you like a real player now.";
                    houseBankDouble = 150;
                    level3.Checked = true;
                }
                if (houseLimit == 17)
                {
                    houseOutputLabel.Text = "Again?! Okay, the kiddie gloves are coming off.";
                    houseBankDouble = 200;
                    level4.Checked = true;
                }
                if (houseLimit == 18)
                {
                    houseOutputLabel.Text = "ARGH!! I will crush you!";
                    houseBankDouble = 300;
                    level5.Checked = true;
                }
                if (houseLimit == 19)
                {
                    okButton.Visible = false;
                    houseOutputLabel.Text = "Okay, you completely won... I'm done...";
                    houseOutputLabel.Refresh();
                    Thread.Sleep(4000);
                    restart();
                }
                houseBankTextBox.Text = houseBankDouble.ToString();
            }
        } // end nextLevel

        // Allow for toolbar to appear with mouse hover at almost any time
        private void toolStripEnabler_Tick(object sender, EventArgs e)
        {
            if (passCount < 1)
            {
                passCount++;
                mouseY1 = BlackjackForm.ActiveForm.Top + 30;
                mouseY2 = BlackjackForm.ActiveForm.Top + 56;
                mouseX1 = BlackjackForm.ActiveForm.Left;
                mouseX2 = BlackjackForm.ActiveForm.Right;
            }

            if (MousePosition.X > mouseX1 && MousePosition.Y < mouseX2)
            {
                if (MousePosition.Y > mouseY1 && MousePosition.Y < mouseY2)
                {
                    toolStrip.Visible = true;
                    return;
                }
            }
            toolStrip.Visible = false;
        } // end toolStripEnabler_Tick

        private void cardStylesTS_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (houseCard2Picture.Image == cardBack.Image)
            { check = true; }
            else { check = false; }

            if ( (cardBackCount < 3))
            {
            cardBackCount++;
            cardBack.Load("classic-cards\\b" + cardBackCount + "fv.png");
            }
            else
            {
                cardBack.Load("classic-cards\\53.png");
                cardBackCount = 0;
            }

            deckTopPicture.Image = cardBack.Image;
            deckTopPicture.Refresh();

            if (check == true)
            {
                houseCard2Picture.Image = cardBack.Image;
                houseCard2Picture.Refresh();
            }

        } // end cardStylesTS_Click

        #region Level Options

        private void level1_Click(object sender, EventArgs e)
        {
            clearCards();

            level1.Checked = true;
            level2.Checked = false;
            level3.Checked = false;
            level4.Checked = false;
            level5.Checked = false;

            houseLimit = 14;
            houseOutputLabel.Text = "Hey! So you wanna face off? \r\nI'll start off easy. How does $50 sound?";
            houseBankDouble = 50;
            houseBankTextBox.Text = houseBankDouble.ToString();

            resultLabel.Text = "";
            bankDouble = 300;
            bankTextBox.Text = bankDouble.ToString();

            houseOutputLabel.Visible = true;
            okButton.Visible = true;
            betTextBox.ReadOnly = true;
            dealButton.Enabled = false;
            dealButton.Visible = true;
            hitButton.Visible = false;
            stayButton.Visible = false;

        }

        private void level2_Click(object sender, EventArgs e)
        {
            clearCards();
            
            houseLimit = 14;
            levelSelectAllow = 1;
            nextLevel();
        }

        private void level3_Click(object sender, EventArgs e)
        {
            clearCards();

            houseLimit = 15;
            levelSelectAllow = 1;
            nextLevel();
        }

        private void level4_Click(object sender, EventArgs e)
        {
            clearCards();

            houseLimit = 16;
            levelSelectAllow = 1;
            nextLevel();
        }

        private void level5_Click(object sender, EventArgs e)
        {
            clearCards();

            houseLimit = 17;
            levelSelectAllow = 1;
            nextLevel();
        }

        #endregion

        // Borrowed code to prevent movement of window (Causes problem with toolbar)
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        #endregion

    }
}