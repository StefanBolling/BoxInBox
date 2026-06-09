using System;

namespace BoxInBox;

public class BoxFactory
{
    public Box CreateBoxWithContainingBoxes(int numberOfContainingBoxes)
    {
        if (numberOfContainingBoxes < 1)
            throw new ArgumentOutOfRangeException(
                nameof(numberOfContainingBoxes), "Must be at least 1.");

        var box = new Box();
        for (var i = 0; i < numberOfContainingBoxes; i++)
            box = new Box { ContainedBox = box };

        return box;
    }
}
