using System;

namespace TNRD.AdventOfCode.DayOne.PuzzleTwo
{
    public class PuzzleSolver : Foundation.PuzzleSolver
    {
        public PuzzleSolver(int day, string sessionCookie) : base(day, sessionCookie)
        {
        }

        public override void Solve()
        {
            int floor = 0;
            int result = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                char c = Input[i];

                if (c == '(')
                    ++floor;
                else if (c == ')')
                    --floor;

                if (floor == -1)
                {
                    result = i + 1;
                    break;
                }
            }

            Console.WriteLine($"Puzzle answer for day {Day} is {result}");
        }
    }
}
