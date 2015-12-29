/*  _____                     _               _____                      
   |  __ \                   (_)             |  __ \                     
   | |  \/_   _  ___  ___ ___ _ _ __   __ _  | |  \/ __ _ _ __ ___   ___ 
   | | __| | | |/ _ \/ __/ __| | '_ \ / _` | | | __ / _` | '_ ` _ \ / _ \
   | |_\ \ |_| |  __/\__ \__ \ | | | | (_| | | |_\ \ (_| | | | | | |  __/
    \____/\__,_|\___||___/___/_|_| |_|\__, |  \____/\__,_|_| |_| |_|\___|
                                       __/ |                             
                                      |___/                                   
 */

/* Author: Erik Humphrey
 * Project title: Project 9 - Guessing Game
 * Date created: October 15
 * Executable name: HumphreyErikGuessPuzzle.exe
 * Icon design: Erik Humphrey
 * Description: Game where the player guesses a random single-digit number, being given hints should they guess incorrectly
*/

/*** Notes ***
 * Heavily tries to mimick old school RuneScape 2 menus
 * Has nonstandard fonts bundled with the program. Hope they work.
 *** Step integer ***
 * User clicks label --> it changes to Please wait..." --> timer ticks after artificial loading time --> changes tab etc
 * 1: Program executed 
 * 2: User clicks "Click here to continue", random number is generated
 * 3: User loads into guess interface
 * 4: User guesses incorrectly
 * 5: User guesses correctly
 * 6: User clicks "Click here to continue" after guessing incorrectly
 * 7: User clicks "Click here to continue" after guessing correctly
 * 8: User loads into quest complete interface
 * 9: User clicks "Click here to continue" on quest complete interface
 * 11: User chooses to not reset puzzle and close the program
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text; // For the custom font
using System.Linq;
using System.Media; // to use SoundPlayer
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErikGuessPuzzle
{
    public partial class frmGuessPuzzle : Form
    {
        // This should bundle the custom font so that it doesn't have to be directly installed on the user's system
        // Based off MSDN documentation

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fontDank;

        // Global variables 
        int step = 1;
        bool artificiallyWaiting = false;
        int answer;
        int guess;
        int numberOfAttempts; // Just works better if global

        public frmGuessPuzzle()
        {
            // Declare custom font

            InitializeComponent();

            byte[] fontData = Properties.Resources.fontGuessPuzzle;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.fontGuessPuzzle.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.fontGuessPuzzle.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontDank = new Font(fonts.Families[0], 16.0F);

            InitializeComponent();
            tmrPleaseWait.Start(); // Start the timer
        }

        // Make sure EVERYTHING has the custom font

        private void frmGuessPuzzle_Load(object sender, EventArgs e)
        {
            lblAttempts.Font = fontDank;
            lblClickToAskForReplay.Font = fontDank;
            lblClickToContinue.Font = fontDank;
            lblCongratulationsQuestComplete.Font = fontDank;
            lblGuess1.Font = fontDank;
            lblGuess2.Font = fontDank;
            lblGuess3.Font = fontDank;
            lblGuess4.Font = fontDank;
            lblGuess5.Font = fontDank;
            lblGuess6.Font = fontDank;
            lblGuess7.Font = fontDank;
            lblGuess8.Font = fontDank;
            lblGuess9.Font = fontDank;
            lblGnomeChat.Font = fontDank;
            lblGnomeName.Font = fontDank;
            lblNoReplay.Font = fontDank;
            lblResetPuzzle.Font = fontDank;
            lblSelectAnOption.Font = fontDank;
            lblWannaReset.Font = fontDank;
            tabAskForReplay.Font = fontDank;
            tabGuess.Font = fontDank;
            tabGnomeDialogue.Font = fontDank;
            tabQuestComplete.Font = fontDank;
        }

        // Click to continue button on gnome dialogue tab

        private void lblClickToContinue_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblClickToContinue.Text = "Please wait...";
            lblClickToContinue.ForeColor = Color.Blue;

            if (step == 1)
            {
                step = 2;
            }

            if (step == 4)
            {
                step = 6;
            }

            if (step == 5)
            {
                step = 7;
            }
        }

        private void lblClickToContinue_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting) // Prevents mouseover colour change when "Please wait..." is up
            {
                lblClickToContinue.ForeColor = Color.White;
            }
        }

        private void lblClickToContinue_MouseLeave(object sender, EventArgs e)
        {
            lblClickToContinue.ForeColor = Color.Blue;
        }

        // Guess tab

        private void lblGuess1_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess1.Text = "Please wait...";
            lblGuess1.ForeColor = Color.Black;
            guess = 1; // Register user guess as an integer
        }

        private void lblGuess2_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess2.Text = "Please wait...";
            lblGuess2.ForeColor = Color.Black;
            guess = 2;
        }

        private void lblGuess3_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess3.Text = "Please wait...";
            lblGuess3.ForeColor = Color.Black;
            guess = 3;
        }

        private void lblGuess4_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess4.Text = "Please wait...";
            lblGuess4.ForeColor = Color.Black;
            guess = 4;
        }

        private void lblGuess5_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess5.Text = "Please wait...";
            lblGuess5.ForeColor = Color.Black;
            guess = 5;
        }

        private void lblGuess6_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess6.Text = "Please wait...";
            lblGuess6.ForeColor = Color.Black;
            guess = 6;
        }

        private void lblGuess7_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess7.Text = "Please wait...";
            lblGuess7.ForeColor = Color.Black;
            guess = 7;
        }

        private void lblGuess8_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess8.Text = "Please wait...";
            lblGuess8.ForeColor = Color.Black;
            guess = 8;
        }


        private void lblGuess9_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblGuess9.Text = "Please wait...";
            lblGuess9.ForeColor = Color.Black;
            guess = 9;
        }

        private void lblGuess1_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess1.ForeColor = Color.White;
        }

        private void lblGuess2_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess2.ForeColor = Color.White;
        }

        private void lblGuess3_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess3.ForeColor = Color.White;
        }

        private void lblGuess4_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess4.ForeColor = Color.White;
        }

        private void lblGuess5_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess5.ForeColor = Color.White;
        }

        private void lblGuess6_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess6.ForeColor = Color.White;
        }

        private void lblGuess7_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess7.ForeColor = Color.White;
        }

        private void lblGuess8_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess8.ForeColor = Color.White;
        }

        private void lblGuess9_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblGuess9.ForeColor = Color.White;
        }

        private void lblGuess1_MouseLeave(object sender, EventArgs e)
        {
            lblGuess1.ForeColor = Color.Black;
        }

        private void lblGuess2_MouseLeave(object sender, EventArgs e)
        {
            lblGuess2.ForeColor = Color.Black;
        }

        private void lblGuess3_MouseLeave(object sender, EventArgs e)
        {
            lblGuess3.ForeColor = Color.Black;
        }

        private void lblGuess4_MouseLeave(object sender, EventArgs e)
        {
            lblGuess4.ForeColor = Color.Black;
        }

        private void lblGuess5_MouseLeave(object sender, EventArgs e)
        {
            lblGuess5.ForeColor = Color.Black;
        }

        private void lblGuess6_MouseLeave(object sender, EventArgs e)
        {
            lblGuess6.ForeColor = Color.Black;
        }

        private void lblGuess7_MouseLeave(object sender, EventArgs e)
        {
            lblGuess7.ForeColor = Color.Black;
        }

        private void lblGuess8_MouseLeave(object sender, EventArgs e)
        {
            lblGuess8.ForeColor = Color.Black;
        }

        private void lblGuess9_MouseLeave(object sender, EventArgs e)
        {
            lblGuess9.ForeColor = Color.Black;
        }

        // Timer is always running, so "Please wait..." won't always last 650ms, that's just how often the time checks.

        private void tmrPleaseWait_Tick(object sender, EventArgs e)
        {
            if (step == 2)
            {
                        Random rnd = new Random();
                        answer = rnd.Next(1, 10);
                        step = 3;
                        tabsSections.SelectedTab = tabGuess;
                        numberOfAttempts = 0; // Reset number of attempts, for replays
            }

            if (step == 3 && guess > 0 && guess < 10)
            {
                tabsSections.SelectedTab = tabGnomeDialogue;

                if (guess == answer)
                {
                    numberOfAttempts++;
                    lblGnomeChat.Text = "Wow! That worked! Thank you, hero!";
                    picGnomeChild.Image = Properties.Resources.gnome20; // Gnome grins with determination if user guesses correctly
                    step = 5;
                    guess = 0; // reset guess
                }
                else if (guess > answer)
                {
                    step = 4;
                    guess = 0;
                    numberOfAttempts++;
                    picGnomeChild.Image = Properties.Resources.gnome23; // Gnome looks up in thought if user guess is too high
                    lblGnomeChat.Text = "Hmm, nope. Something tells me what you guessed is too high.";
                }
                else if (guess < answer)
                {
                    step = 4;
                    guess = 0;
                    numberOfAttempts++;
                    picGnomeChild.Image = Properties.Resources.gnome13; // Gnome tilts back head and smiles if user guess is too low
                    lblGnomeChat.Text = "That number is too low. Give it another try, adventurer. You can do it!";
                }
            }

            if (step == 6)
            {
                step = 3;
                tabsSections.SelectedTab = tabGuess;
            }

            if (step == 7)
            {
                // Play fanfare audio
                SoundPlayer sndCongrats = new SoundPlayer(HumphreyErikGuessPuzzle.Properties.Resources.Congratulations);
                sndCongrats.Play();
                tabsSections.SelectedTab = tabQuestComplete;
                // Display number of attempts it took to guess the number
                lblAttempts.Text = "It took you " + Convert.ToString(numberOfAttempts) + " attempts to find the gnome's number."; 
                step = 8;
            }

            if (step == 9)
            {
                tabsSections.SelectedTab = tabAskForReplay;
            }

            if (step == 11)
            {
                this.Close();
            }

            // Reset all "Please wait..." labels
            artificiallyWaiting = false;
            lblGuess1.Text = "one (1)";
            lblGuess2.Text = "two (2)";
            lblGuess3.Text = "three (3)";
            lblGuess4.Text = "four (4)";
            lblGuess5.Text = "five (5)";
            lblGuess6.Text = "six (6)";
            lblGuess7.Text = "seven (7)";
            lblGuess8.Text = "eight (8)";
            lblGuess9.Text = "nine (9)";
            lblClickToContinue.Text = "Click here to continue";
            lblClickToAskForReplay.Text = "Click here to continue";
            lblResetPuzzle.Text = "Yes, I want to try again!";
            lblNoReplay.Text = "No, close the program.";
        }

        // "Click here to continue" label on quest complete interface

        private void lblClickToAskForReplay_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblClickToAskForReplay.Text = "Please wait...";
            lblClickToAskForReplay.ForeColor = Color.Blue;
            step = 9;
        }

        private void lblClickToAskForReplay_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting) // Prevents mouseover colour change when "Please wait..." is up
            lblClickToAskForReplay.ForeColor = Color.White;
        }

        private void lblClickToAskForReplay_MouseLeave(object sender, EventArgs e)
        {
            lblClickToAskForReplay.ForeColor = Color.Blue;
        }

        // Close button

        // Change colour (image) when the pointer moves over the control

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.closexmouseover;
        }

        // Change colour back when pointer leaves control

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.closex;
        }

        private void Close(object sender, MouseEventArgs e)
        {
            this.Close(); // Exit the program (X on gnome dialogue tab)
        }

        // Reset puzzle label

        private void lblResetPuzzle_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblResetPuzzle.Text = "Please wait...";
            lblResetPuzzle.ForeColor = Color.Black;
            step = 2;
        }

        private void lblResetPuzzle_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblResetPuzzle.ForeColor = Color.White;
        }

        private void lblResetPuzzle_MouseLeave(object sender, EventArgs e)
        {
            lblResetPuzzle.ForeColor = Color.Black;
        }

        // "No, close the program" label

        private void lblNoReplay_Click(object sender, EventArgs e)
        {
            artificiallyWaiting = true;
            lblNoReplay.Text = "Please wait...";
            lblNoReplay.ForeColor = Color.Black;
            step = 11;
        }

        private void lblNoReplay_MouseEnter(object sender, EventArgs e)
        {
            if (!artificiallyWaiting)
                lblNoReplay.ForeColor = Color.White;
        }

        private void lblNoReplay_MouseLeave(object sender, EventArgs e)
        {
            lblNoReplay.ForeColor = Color.Black;
        }
    }

}
