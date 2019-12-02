namespace TNRD.AdventOfCode.DayThree.Shared
{
    public class DeliveryBoy
    {
        private readonly string input;
        private readonly Map map;

        private int x;
        private int y;

        public int HouseCount => map.CountHousesWithPackage();

        public DeliveryBoy(string input)
        {
            this.input = input;

            map = new Map();
            x = 0;
            y = 0;
        }

        public void WalkPath()
        {
            map.GetHouse(0, 0).DeliverPackage();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                Direction direction = ConvertToDirection(c);

                switch (direction)
                {
                    case Direction.North:
                        ++y;
                        break;
                    case Direction.South:
                        --y;
                        break;
                    case Direction.East:
                        ++x;
                        break;
                    case Direction.West:
                        --x;
                        break;
                }

                House house = map.GetHouse(x, y);
                house.DeliverPackage();
            }
        }

        private Direction ConvertToDirection(char input)
        {
            return (Direction) input;
        }
    }
}
