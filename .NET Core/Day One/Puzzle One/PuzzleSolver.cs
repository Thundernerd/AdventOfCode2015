using System;
using System.Linq;

namespace TNRD.AdventOfCode.DayOne.PuzzleOne
{
    public class PuzzleSolver : Foundation.PuzzleSolver
    {
        public PuzzleSolver(int day, string sessionCookie) : base(day, sessionCookie)
        {
        }

        public override void Solve()
        {
            int sum = Input.Select(ConvertToInt).Sum();
            Console.WriteLine($"Puzzle answer for day {Day} is {sum}");
        }

        private int ConvertToInt(char value)
        {
            if (value == '(')
                return 1;

            if (value == ')')
                return -1;

            return 0;
        }
    }
}
