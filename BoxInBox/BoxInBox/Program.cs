using System;

namespace BoxInBox;

internal class Program
{
    private static readonly BoxFactory BoxFactory = new();

    private static void Main(string[] args)
    {
        var boxWithOneBox = BoxFactory.CreateBoxWithContainingBoxes(1);
        var boxWithSixBoxes = BoxFactory.CreateBoxWithContainingBoxes(6);
        var boxWithTwoBoxes = BoxFactory.CreateBoxWithContainingBoxes(11);

        Console.WriteLine($"Box with one containing boxes contains { boxWithOneBox.GetNumberOfContainingBoxes } boxes");
        Console.WriteLine($"Box with six containing boxes contains { boxWithSixBoxes.GetNumberOfContainingBoxes } boxes");
        Console.WriteLine($"Box with eleven containing boxes contains { boxWithTwoBoxes.GetNumberOfContainingBoxes } boxes");

        Console.ReadKey();
    }
}