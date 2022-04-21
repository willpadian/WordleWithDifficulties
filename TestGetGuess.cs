using System;

namespace WordleProject
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
            Console.WriteLine("You should see a message prompting you to make a guess.");
            Console.WriteLine("Guess the word trash.");
            string result = Program.GetGuess("drags");
            string expected = "trash";
            if (result != expected)
            {
                Console.Error.WriteLine($"The result should have been 'trash' but was {result}");
                return false;
            }

            Console.WriteLine("You should see a message prompting you to make a guess.");
            Console.WriteLine("Guess the word chocolate. This should be invalid.");
            Console.WriteLine("Now enter dog. This should be invalid.");
            Console.WriteLine("Finally, enter rupee");

            result = Program.GetGuess("drags");
            expected = "rupee";
            if (result != "rupee")
            {
                Console.Error.WriteLine($"The result should have been 'rupee' but was {result}");
                return false;
            }


            try
            {
                Program.GetGuess(null);
                Console.Error.WriteLine($"The result should have been an exception but it wasn't.");

                return false;
            }
            catch { }


            return true;
        }
    }


}