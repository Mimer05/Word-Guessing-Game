using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Guessing_Game
{
    public partial class Form2 : Form
    {
        // initializing the Listing of  possible Guessing word, the Random word, The display output, and the wrong guess
        ArrayList words = new ArrayList { "magician", "explorer", "crocodile" };
        string WordRandom;
        StringBuilder Display;
        ArrayList WrongGuess = new ArrayList();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { // calling the method of the words guess
            Game();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        { //clear button that will clear the user input text box
            tbUserInput.Text = "";
        }

        private void btnGuess_Click_1(object sender, EventArgs e)
        {     //Guess button that will have decision statements to know if user input is wrong or not
            string userInput = tbUserInput.Text.ToLower();
            // Check if the word input matches the selected word
            if (!string.IsNullOrEmpty(userInput))
            {
                if (userInput.Equals(WordRandom))
                {   // If the guessed word match
                    MessageBox.Show("Correct guess!");
                    txtGuessWord.Text = WordRandom; 
                }
                else
                {
                    // Add incorrect guess to the list
                    if (!WrongGuess.Contains(userInput))
                    {
                        WrongGuess.Add(userInput);
                        lbWrongGuess.Items.Add(userInput); // show the wrong guess in the list box
                    }
                    MessageBox.Show("Incorrect guess!\n Try again.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.\n Try Again.");
            }
            // Clear the input box for the next guess
            tbUserInput.Clear();
        }
        private void Game()
        {//method that will show the label word random that need to guess
            Random random = new Random();
            WordRandom = (string)words[random.Next(words.Count)];

            // Initialize The hint word with underscores, that show only the first and last letter
            Display = new StringBuilder(new string('_', WordRandom.Length));
            Display[0] = WordRandom[0]; // First letter hint
            Display[WordRandom.Length - 1] = WordRandom[WordRandom.Length - 1]; // Last letter hint
            // the UI with the initial display 
            txtGuessWord.Text = FormatDisplayWord(Display.ToString());
            // Clear wrong guesses list box
            WrongGuess.Clear();
            lbWrongGuess.Items.Clear();
        }
        // method that Format the display
        private string FormatDisplayWord(string word)
        {
            StringBuilder formattedWord = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {// Add each character followed by a space
                formattedWord.Append(word[i] + " "); 
            }
            // Trim the extra space at the end
            return formattedWord.ToString().Trim(); 
        }
        private void button1_Click(object sender, EventArgs e)
        { //button to go to the first web form 
            this.Hide();
            Form1 Other = new Form1();
            Other.Show();
        }
    }
}
