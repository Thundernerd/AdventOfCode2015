namespace TNRD.AdventOfCode.DayThree.Shared
{
    public class House
    {
        public int PackagesReceived { get; private set; }

        public House(int x, int y)
        {
        }

        public void DeliverPackage()
        {
            ++PackagesReceived;
        }
    }
}
