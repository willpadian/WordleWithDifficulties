using System;

namespace WordleProject
{
    class TestDisplayInfo
    {
        public static bool RunTest()
        {
            Console.WriteLine("You should see a red 'g' in postition 0, a green 'r in position 1, a red 'a' in position 2, a red 's' in position 3, and a red 's' in position 4.");
            Program.DisplayInfo("grass", "drive");

            Console.WriteLine("You should see a red 'g' in postition 0, a yellow 'r in position 1, a red 'a' in position 2, a red 's' in position 3, and a green 's' in position 4.");
            Program.DisplayInfo("grass", "rides");

            try
            {
                Program.DisplayInfo("chocolate", "drive");
                Console.Error.WriteLine("Expected an exception but there was none.");
                return false;
            }
            catch { }
            return true;
        }
    }

}

