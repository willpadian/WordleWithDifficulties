using System;
using System.Collections.Generic;

namespace WordleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }

            Console.WriteLine("Welcome to Willdle!");

            Console.WriteLine("Enter either Easy, Medium, or Hard to indicate which difficulty you would like to play.");
            string answer = Console.ReadLine();
            string correct;
            if (answer == "Easy")
            {
                 correct = GetRandomWordEasy();
            }
            else if (answer == "Medium")
            {
                 correct = GetRandomWordMedium();
            }
            else if (answer == "Hard")
            {
                 correct = GetRandomWordHard();
            }
            else{
                throw new Exception("You should have entered either Easy, Medium, or Hard");
                
            }
            string guess = "";
            while (correct != guess)
            {
                guess = GetGuess(correct);
                DisplayInfo(guess, correct);
                Console.WriteLine();
            }


        }
        public static void TestAll()
        {
            bool testDisplayInfo = TestDisplayInfo.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testDisplayInfo}");

            bool testDisplayCharInfo = TestDisplayCharInfo.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testDisplayCharInfo}");

            bool testGetGuess = TestGetGuess.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testGetGuess}");

            bool testGetRandomWord = TestGetRandomWord.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testGetRandomWord}");
        }
        /// <summary>
        /// It will generate a random word then returns it.
        /// </summary>
        /// <returns>a random word</returns>
        public static string GetRandomWordEasy()
        {
            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            List<string> words = new List<string>();

            words.Add("sharp");
            words.Add("white");
            words.Add("plays");
            words.Add("light");
            words.Add("reads");
            words.Add("rupee");
            words.Add("blues");
            words.Add("write");
            words.Add("mould");
            words.Add("lapse");

            Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return randomWord;
        }
        public static string GetRandomWordMedium()
        {
            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            List<string> words = new List<string>();

            words.Add("orate");
            words.Add("chase");
            words.Add("banks");
            words.Add("razor");
            words.Add("least");
            words.Add("ready");
            words.Add("whine");
            words.Add("belly");
            words.Add("dread");
            words.Add("wrote");

            Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return randomWord;
        }
        public static string GetRandomWordHard()
        {
            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            List<string> words = new List<string>();

            words.Add("oater");
            words.Add("oxide");
            words.Add("salty");
            words.Add("peers");
            words.Add("rebus");
            words.Add("queue");
            words.Add("whack");
            words.Add("vivid");
            words.Add("swill");
            words.Add("knock");

            Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return randomWord;
        }

        /// <summary>
        /// Given a guess checks the guess whether or not the guess has the right number of letters for the word
        /// </summary>
        /// <param name="correctWord"></param>
        /// <returns>either error if the word isn't the right size or feedback on the guess</returns>
        public static string GetGuess(string correctWord)
        {
            string input;
            do
            {
                Console.Write("Enter a guess for a word that is exactly five letters.");
                input = Console.ReadLine();
                if (input.Length != correctWord.Length)
                {
                    Console.WriteLine("Invalid Guess! Make a guess that is 5 letters.");
                }
            } while (input.Length != correctWord.Length);
            // 1. Prompt the user to make a guess
            // 2. Read input from the keyboard and store the results in a variable named guess
            // 3. If guess is the correct length (the guess and random word should be the same length), return the guess.
            // Otherwise, display an error message and ask them to make another guess.
            return input;
        }
        /// <summary>
        /// Check if the guess is the right length and if not throw an exception and if they do use the next variable to determine the validity of the guess.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="correct"></param>

        public static void DisplayInfo(string guess, string correct)
        {
            if (guess.Length != correct.Length)
            {
                throw new Exception($"Expected {guess} and {correct} to have the same length.");
            }

            int index = 0;
            while (index < correct.Length)
            {
                char guessChar = guess[index];
                char correctChar = correct[index];
                DisplayCharInfo(guessChar, index, correct);
                index = index + 1;
            }



            // 1. Validate that the guess and correct word are the same length
            // 2. If the lengths do not match, throw an exception
            // 3. If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
        }
        /// <summary>
        /// Use green when the letter is correct and in the right position from the input, use yellow if the letter is in the word but in the wrong position, and use red if it is not in the word at all.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="pos"></param>
        /// <param name="correct"></param>
        public static void DisplayCharInfo(char guess, int pos, string correct)
        {
            if (guess == correct[pos])
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (correct.Contains(guess))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write($"{guess}");
            Console.ForegroundColor = ConsoleColor.White;

            // 1. If the guess is in the correct position, select the color green.
            // 2. If the guess is in the correct word but not correct position, select yellow.
            // 3. If the guess is not in the correct word, select red.
            // 4. Display the guess
            // 5. Reset the color back to white before returning

        }
    }
}
