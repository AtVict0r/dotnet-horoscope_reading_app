using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopeReading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char firstLetter = ' ';
        int nameLength = 0;

        private void verifyUsernameButton_Click(object sender, EventArgs e)
        {
            invalidNameLabel.Text = String.Empty;
            verifyNameLabel.Text = String.Empty;
            yesButton.Visible = false;
            noButton.Visible = false;
            getReadingLabel.Text = String.Empty;

            string userName = usernameTextBox.Text;
            
            if (userName.All(Char.IsLetter) && userName != "")
            {
                verifyNameLabel.Text = $"Is {userName} the name you entered?";
                yesButton.Visible = true;
                noButton.Visible = true;
                firstLetter = userName[0];
                nameLength = userName.Length;
            }
            else 
            {
                invalidNameLabel.Text = "Your name should only contain alphabets.\nSpecial characters and numbers are not allowed!.\nTry Again!!";
                usernameTextBox.Text = String.Empty;
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            invalidNameLabel.Text = String.Empty;
            verifyNameLabel.Text = "Enter your name again.";
            yesButton.Visible = false;
            noButton.Visible = false;
            getReadingLabel.Text = String.Empty;
            firstLetter = ' ';
            nameLength = 0;
            usernameTextBox.Text = String.Empty;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            invalidNameLabel.Text = String.Empty;
            verifyNameLabel.Text = String.Empty;
            getReadingLabel.Text = String.Empty;
            usernameTextBox.Text = String.Empty;

            Random rnd = new Random();
            int num = rnd.Next(Math.Min((int)firstLetter, nameLength), Math.Min(Math.Max((int)firstLetter, nameLength), 26));

            string[] message = new string[] {"A friend is hidding something from you.",
                                             "Start something new today.",
                                             "Revisit the past.",
                                             "Finish an uncompleted project.",
                                             "Take sometime today to appreciate your surrounding.",
                                             "Look at it from a different perspective.",
                                             "Look towards the future.",
                                             "You still have time.",
                                             "You can always try again.",
                                             "Don't be afraid of failure.",
                                             "It is never too late.",
                                             "It is okay to move.",
                                             "Get out of your comfort zone.",
                                             "Be flexible.",
                                             "You are not the center of the universe.",
                                             "Put in more effort.",
                                             "The road is just up ahead.",
                                             "Have faith.",
                                             "It will work out.",
                                             "A bit of positivity goes a long way.",
                                             "Slow and steady wins the race.",
                                             "Be calm and confident.",
                                             "Time is on your side.",
                                             "Explore new things today.",
                                             "Listen to the advice you get today",
                                             "You will influence someone today"};

            getReadingLabel.Text = "Getting reading...\n..." + message[num];
        }
    }
}
