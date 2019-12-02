namespace TNRD.AdventOfCode.DayOne.PuzzleTwo
{
    public class PuzzleSolver : Foundation.PuzzleSolver
    {
        public override int Day => 1;

        public PuzzleSolver(string sessionCookie) : base(sessionCookie)
        {
        }

        public override object Solve()
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

            return result;
        }
    }
}
