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
        Assert.That(numberOfContainingBoxes, Is.EqualTo(1));
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
        Assert.That(numberOfContainingBoxes, Is.EqualTo(4));
    }

    [Test]
    public void EmptyBoxShouldContainNoBoxes()
    {
        // Arrange
        var emptyBox = new Box();

        // Act
        var numberOfContainingBoxes = emptyBox.GetNumberOfContainingBoxes;

        // Assert
        Assert.That(numberOfContainingBoxes, Is.EqualTo(0));
    }

    [Test]
    public void GetNumberOfContainingBoxesShouldBeStableAcrossRepeatedReads()
    {
        // Arrange
        var boxWithTwoContainedBoxes = new Box { ContainedBox = new Box { ContainedBox = new Box() } };

        // Act
        var firstRead = boxWithTwoContainedBoxes.GetNumberOfContainingBoxes;
        var secondRead = boxWithTwoContainedBoxes.GetNumberOfContainingBoxes;
        var thirdRead = boxWithTwoContainedBoxes.GetNumberOfContainingBoxes;

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(firstRead, Is.EqualTo(2));
            Assert.That(secondRead, Is.EqualTo(2));
            Assert.That(thirdRead, Is.EqualTo(2));
        });
    }
}