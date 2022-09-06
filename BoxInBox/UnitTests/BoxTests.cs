using BoxInBox;
using NUnit.Framework;

namespace UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BoxWithOneBoxShouldSayItContainsOneBox()
    {
        // Arrange
        var boxWithOneContainedBox = new Box { ContainedBox = new Box() };

        // Act
        var numberOfContainingBoxes = boxWithOneContainedBox.GetNumberOfContainingBoxes;

        // Assert
        Assert.AreEqual(1, numberOfContainingBoxes);
    }

    [Test]
    public void BoxWithFourBoxShouldSayItContainsFourBoxes()
    {
        // Arrange
        var boxWithOneBox = new Box { ContainedBox = new Box() };
        var boxWithTwoBoxes = new Box { ContainedBox = boxWithOneBox };
        var boxWithThreeBoxes = new Box { ContainedBox = boxWithTwoBoxes };
        var boxWithFourBoxes = new Box { ContainedBox = boxWithThreeBoxes };

        // Act
        var numberOfContainingBoxes = boxWithFourBoxes.GetNumberOfContainingBoxes;

        // Assert
        Assert.AreEqual(4, numberOfContainingBoxes);
    }
}