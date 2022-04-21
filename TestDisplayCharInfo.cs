using System;

namespace WordleProject
{
    class TestDisplayCharInfo
    {
        public static bool RunTest()
        {
            Console.WriteLine("You should see a yellow 'c'.");
            Program.DisplayCharInfo('c', 3, "chard");

            Console.WriteLine("You should see a green 'c'.");
            Program.DisplayCharInfo('c', 0, "chard");

            Console.WriteLine("You should see a red 'z'.");
            Program.DisplayCharInfo('z', 4, "chard");
            return true;
        }
    }


}