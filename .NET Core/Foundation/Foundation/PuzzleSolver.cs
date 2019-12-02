namespace TNRD.AdventOfCode.Foundation
{
    public abstract class PuzzleSolver : IPuzzleSolver
    {
        public abstract int Day { get; }
        protected string Input { get; }

        public PuzzleSolver(string sessionCookie)
        {
            Input = PuzzleInputDownloader.DownloadInput(Day, sessionCookie);
        }

        public abstract object Solve();
    }
}
