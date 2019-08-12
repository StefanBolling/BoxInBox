using System;

namespace BoxInBox
{
    class Program
    {
        private static readonly BoxFactory _boxFactory = new BoxFactory();
        static void Main(string[] args)
        {
            var boxWithOneBox = _boxFactory.CreateBoxWithContainingBoxes(1);
            var boxWithSixeBoxes = _boxFactory.CreateBoxWithContainingBoxes(6);
            var BoxWithTwoBoxes = _boxFactory.CreateBoxWithContainingBoxes(11);

            Console.WriteLine($"Box with one containing boxes contains {boxWithOneBox.GetNumberOfContaintingBoxes} boxes");
            Console.WriteLine($"Box with six containing boxes contains {boxWithSixeBoxes.GetNumberOfContaintingBoxes} boxes");
            Console.WriteLine($"Box with eleven containing boxes contains {BoxWithTwoBoxes.GetNumberOfContaintingBoxes} boxes");

            Console.ReadKey();
        }
    }
}