using TNRD.AdventOfCode.DayThree.Shared;

namespace TNRD.AdventOfCode.DayThree.PuzzleOne
{
    public class PuzzleSolver : Foundation.PuzzleSolver
    {
        public override int Day => 3;

        public PuzzleSolver(string sessionCookie) : base(sessionCookie)
        {
        }

        public override object Solve()
        {
            DeliveryBoy deliveryBoy = new DeliveryBoy(Input);
            deliveryBoy.WalkPath();
            return deliveryBoy.HouseCount;
        }
    }
}
