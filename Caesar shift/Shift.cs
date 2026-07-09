using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caesar_shift
{
    public class Shift
    {
        private Dictionary<int, string> alphabet = new Dictionary<int, string>();

        private static readonly double[] letterFrequency =
        {
                8.2, 1.5, 2.8, 4.3, 12.7, 2.2, 2.0, 6.1, 7.0, 0.2, 0.8, 4.0, 2.4,
                6.7, 7.5, 1.9, 0.1, 6.0, 6.3, 9.1, 2.8, 1.0, 2.4, 0.2, 2.0, 0.1
        };

        public Shift()
        {
            CaesarShift_Load();
        }



        private void CaesarShift_Load()
        {


            alphabet = new Dictionary<int, string>();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphabet.Add(c - 'A' + 1, c.ToString());

            }

        }

        public string AutoGuess(string guess)
        {
            if (string.IsNullOrEmpty(guess))
                return "enter some text first";

            string bestResult = " ";
            double bestScore = -1;
            int bestShift = 0;

            for (int i = 1; i <= 25; i++)
            {
                string result = runShift(i, guess);
                double score = ScoreText(result);

                if (score > bestScore) (bestScore, bestResult, bestShift) = (score, result, i);


            } 
            return $"Best shift: ( {bestShift} ): {bestResult}";

        }

        private double ScoreText(string result) => result.ToUpper().Where(char.IsLetter).Sum(c => letterFrequency[c - 'A']);

        public string IsValid(int countResult, string codeText)
        {

                if (countResult < 1 || countResult > 25 )
                {
                    MessageBox.Show("Enter a value between 1-25");
                    return "invalid";
                }

            
            if (string.IsNullOrWhiteSpace(codeText))
            {
                MessageBox.Show("Code text cannot be empty.");
                return "invalid";
            }

            if (codeText.Length < 3)
            {
                MessageBox.Show("Code text is too short.");
                return "invalid";
            }

            return runShift(countResult, codeText);
    
        }

        private string runShift(int shiftCount, string code)
        {

            string result = "";

            foreach (char c in code.ToUpper())
            {
                if (char.IsLetter(c))
                {
                    int currentIndex = c - 'A' + 1;
                    int newIndex = ((currentIndex + shiftCount - 1) % 26) + 1;
                    result += alphabet[newIndex];
                }
                else
                {
                    result += c;
                }

            }

            return result; ;
        }
    }
}
