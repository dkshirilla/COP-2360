//Programmer: Douglas Shirilla
//Date: 04/25/2017
//Course: COP-2360
//Purpose: As a final project for the C# language class, I created a GUI hangman game application.
//The user has 10 guesses to guess the word which is selected at random from a .txt file 
//containing a list of random words. If guessed letter is in the selected word, the guess doesn't
//count against the user and the hidden word displays where the letter is.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Hangman
{
    public partial class Form1 : Form
    {
        //declare needed variables with global scope
        private string chosenWord = "";
        private int maxGuesses = 10;
        private int numOfGuesses = 0;
        private string hiddenWord = "";
        private string prevGuesses = "";

        public Form1()
        {
            InitializeComponent();
        }

        //get set for chosenWord
        public string theWord
        {
            get { return chosenWord; }
            set
            {
                chosenWord = value;
            }
        }

        //get set for hiddenWord
        public string theHiddenWord
        {
            get { return hiddenWord; }
            set { hiddenWord = value; }
        }

        //method to pull and fill chosenWord from .txt file
        public String createWord()
        {

            //replace this string with your own .txt file of words
            String path = @"C:\Users\Douglas\Desktop\School\COP-2360\Project\words.txt";

            var lines = File.ReadAllLines(path);
            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            var line = lines[randomLineNumber];
            chosenWord = line.ToString();
            return chosenWord;
        }

        //method to create hiddenWord and use & characters to block out answer
        public String createHiddenWord()
        {
            int numOfletters = chosenWord.Length;
            for (int i = 0; i < numOfletters; i++)
            {
                hiddenWord += '&';
            }
            return hiddenWord;
        }


        //sets the textbox to hiddenWord
        public void setAnswer(String hiddenWord)
        {
            answerTextBox.Text = hiddenWord;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize first round of fields for user
            theWord = createWord();
            theHiddenWord = createHiddenWord();
            setAnswer(theHiddenWord);
            guessNumLab.Text = Convert.ToString(maxGuesses);
        }

        //method to change the hiddenWord to incorporate a correct guess from user
        public void modifyHiddenWord(String input)
        {
            char usersGuess = Convert.ToChar(input);
            int index = chosenWord.IndexOf(input);

            char[] b = chosenWord.ToCharArray();
            char[] a = hiddenWord.ToCharArray();
            for(int i = 0;i < hiddenWord.Length;i++)
            {
                if(b[i] == usersGuess)
                {
                    a[i] = usersGuess;
                }
            }
            
            hiddenWord = new string(a);
            answerTextBox.Text = hiddenWord;

        }


        //button click triggered event
        private void guessButton_Click(object sender, EventArgs e)
        {
            string input = null;
            input = letterGuessBox.Text;
            int numOfletters = chosenWord.Length;
            
            //check for valid input
            if (input == "")
            {
                MessageBox.Show("Field cannot be blank!");
            }
            else if(prevGuesses.Contains(input)==true)
            {
                MessageBox.Show("You already guessed that letter!");
            }

            //if input is valid and not blank
            else if(chosenWord.Contains(input)==true)
            {
                char[] word = chosenWord.ToCharArray();
                char usersGuess = Convert.ToChar(input);
                prevGuesses += input;
                prevGuessDisplay.Text = prevGuesses;
                modifyHiddenWord(input);
                if(hiddenWord.Equals(chosenWord))
                {
                    MessageBox.Show("YOU WON!");
                    setNewGame();
                } 
            }

            //code block for guess that is valid and not in the hiddenWord
            else
            {
                numOfGuesses += 1;
                guessNumLab.Text = Convert.ToString(maxGuesses - numOfGuesses);
                prevGuesses += input;
                prevGuessDisplay.Text = prevGuesses;
            }

            //sets picturebox to image of hangman
            if(numOfGuesses > 0)
            {
                setPictureBox(numOfGuesses);
            }
            
            //if user runs out of guesses
            if (numOfGuesses == maxGuesses)
            {
                MessageBox.Show(String.Format("YOU LOSE! The correct word was {0}", chosenWord));
                setNewGame();
            }
            
        }

        //method to set GUI for new game and reset counters
        public void setNewGame()
        {
            numOfGuesses = 0;
            pictureBox.Image = null;
            prevGuessDisplay.Text = "";
            prevGuesses = " ";
            chosenWord = "";
            hiddenWord = "";
            guessNumLab.Text = Convert.ToString(maxGuesses);
            letterGuessBox.Text = "";
            theWord = createWord();
            theHiddenWord = createHiddenWord();
            setAnswer(theHiddenWord);
        }


        //method to determine what picture to show in picturebox
        public void setPictureBox(int numOfGuesses)
        {
            if(numOfGuesses == 1)
            {
                pictureBox.Image = Properties.Resources.hangmanBody1;
            }
            else if(numOfGuesses == 2)
            {
                pictureBox.Image = Properties.Resources.hangmanBody2;
            }
            else if(numOfGuesses == 3)
            {
                pictureBox.Image = Properties.Resources.hangmanBody3;
            }
            else if(numOfGuesses == 4)
            {
                pictureBox.Image = Properties.Resources.hangmanBody4;
            }
            else if(numOfGuesses == 5)
            {
                pictureBox.Image = Properties.Resources.hangmanBody5;
            }
            else if(numOfGuesses == 6)
            {
                pictureBox.Image = Properties.Resources.HangmanBody6;
            }
            else if(numOfGuesses == 7)
            {
                pictureBox.Image = Properties.Resources.hangmanBody7;
            }
            else if(numOfGuesses == 8)
            {
                pictureBox.Image = Properties.Resources.hangmanBody8;
            }
            else if(numOfGuesses == 9)
            {
                pictureBox.Image = Properties.Resources.hangmanBody9;
            }
            else
            {
                pictureBox.Image = Properties.Resources.hangmanBody10;
            }
        }
    }
}
