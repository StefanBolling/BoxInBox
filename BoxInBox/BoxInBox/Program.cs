using System;

namespace BoxInBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Box with one containing boxes contains {BoxWithOneBox.GetNumberOfContaintingBoxes} boxes");
            Console.WriteLine($"Box with two containing boxes contains {BoxWithTwoBoxes.GetNumberOfContaintingBoxes} boxes");

            Console.ReadKey();
        }

        private static Box BoxWithOneBox
        {
            get
            {
                var boxWithOneContainedBox = new Box { ContainedBox = new Box() };

                return boxWithOneContainedBox;
            }
        }

        private static Box BoxWithTwoBoxes
        {
            get
            {
                var boxWithTwoBoxes = new Box { ContainedBox = BoxWithOneBox };

                return boxWithTwoBoxes;
            }
        }
    }
}