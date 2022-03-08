using System.Collections.Generic;
using System.Linq;
using mastermind.Colours;

namespace mastermind
{
    public class Codebreaker
    {
        public List<Colour> CurrentGuess => Guesses.Last().Get(); //removed
        public List<ColoursList> Guesses; //number of guesses or guess count
        public List<List<Hint.Hint>> Hints; //number of hints = number of guesses
        
        public Codebreaker()
        {
            Guesses = new List<ColoursList>();
            Hints = new List<List<Hint.Hint>>();
        }
        
        public void UpdateGuesses(List<Colour> guess)
        {
            var colourlist = new ColoursList(guess);
            Guesses.Add(colourlist);
        }

        public int GetNumberOfGuesses()
        {
            var numberOfGuesses = 0;

            foreach (var guess in Guesses)
            {
                numberOfGuesses++;
            }

            return numberOfGuesses;
        }
        
    }
}