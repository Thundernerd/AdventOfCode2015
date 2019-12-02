using System;
using System.Collections.Generic;
using System.Linq;

namespace TNRD.AdventOfCode.DayTwo.Shared
{
    public class Prism
    {
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }

        public Prism(string input)
        {
            string[] splits = input.Split('x', StringSplitOptions.RemoveEmptyEntries);
            Length = int.Parse(splits[0]);
            Width = int.Parse(splits[1]);
            Height = int.Parse(splits[2]);
        }

        public int CalculateRequiredPaper()
        {
            return CalculateArea() + GetSmallestArea();
        }

        private int CalculateArea()
        {
            return 2 * Length * Width +
                   2 * Width * Height +
                   2 * Height * Length;
        }

        private int GetSmallestArea()
        {
            return Math.Min(Length * Width, Math.Min(Width * Height, Height * Length));
        }

        public int CalculateRequiredRibbon()
        {
            return CalculateBow() + CalculateWrap();
        }

        private int CalculateBow()
        {
            return Length * Width * Height;
        }

        private int CalculateWrap()
        {
            List<int> orderedNumbers = new List<int>()
            {
                Length, Width, Height
            }.OrderBy(x => x).ToList();
            return orderedNumbers[0] * 2 + orderedNumbers[1] * 2;
        }
    }
}
