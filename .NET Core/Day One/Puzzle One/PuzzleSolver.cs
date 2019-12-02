using System.Linq;

namespace TNRD.AdventOfCode.DayOne.PuzzleOne
{
    public class PuzzleSolver : Foundation.PuzzleSolver
    {
        public override int Day => 1;

        public PuzzleSolver(string sessionCookie) : base(sessionCookie)
        {
        }

        public override object Solve()
        {
            return Input.Select(ConvertToInt).Sum();
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
