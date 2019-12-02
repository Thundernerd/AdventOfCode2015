using System.Collections.Generic;
using System.Linq;

namespace TNRD.AdventOfCode.DayThree.Shared
{
    public class Map
    {
        private Dictionary<int, Dictionary<int, House>> coordinatesToHouse =
            new Dictionary<int, Dictionary<int, House>>();

        public Map()
        {
        }

        public House GetHouse(int x, int y)
        {
            if (!coordinatesToHouse.TryGetValue(x, out Dictionary<int, House> yCoordinateToHouse))
            {
                coordinatesToHouse.Add(x, (yCoordinateToHouse = new Dictionary<int, House>()));
            }

            if (!yCoordinateToHouse.TryGetValue(y, out House house))
            {
                yCoordinateToHouse.Add(y, (house = new House(x, y)));
            }

            return house;
        }

        public int CountHousesWithPackage()
        {
            return coordinatesToHouse
                .SelectMany(x => x.Value)
                .Sum(x => 1);

        }
    }
}
