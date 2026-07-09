using System;
using System.Windows.Forms;

namespace Caesar_shift
{
    public partial class CaesarShift : Form
    {

        public CaesarShift()
        {
            InitializeComponent();
        }


        private void decipherBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(shiftCountBox.Text, out int userInput))
            {
                MessageBox.Show("Enter a number between 1-25");
                return;
            }

            Shift process = new Shift();
            string result = process.IsValid(userInput, codeBox.Text);

            if (result != "invalid")
                outputBox.Text = result;
        }


        private void decipherAllBtn_Click(object sender, EventArgs e)
        {
            outputBox.Text = new Shift().AutoGuess(codeBox.Text);
        }

    }
 }
