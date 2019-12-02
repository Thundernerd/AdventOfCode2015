using System;
using TNRD.AdventOfCode.DayTwo.Shared;

namespace TNRD.AdventOfCode.DayTwo.PuzzleTwo
{
    public class PuzzleSolver : Foundation.PuzzleSolver
    {
        public override int Day => 2;

        public PuzzleSolver(string sessionCookie) : base(sessionCookie)
        {
        }

        public override object Solve()
        {
            string[] splits = Input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            int total = 0;

            foreach (string split in splits)
            {
                Prism prism = new Prism(split);
                total += prism.CalculateRequiredRibbon();
            }

            return total;
        }
    }
}
