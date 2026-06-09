using System;
using BoxInBox;
using NUnit.Framework;

namespace UnitTests;

public class BoxFactoryTests
{
    [SetUp]
    public void Setup()
    {
    }

    private static int CountPhysicallyNestedBoxes(Box box)
    {
        var depth = 0;
        for (var current = box.ContainedBox; current is not null; current = current.ContainedBox)
            depth++;
        return depth;
    }

    [Test]
    public void BoxFactoryShouldDeliverOneBox()
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act
        var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(1);

        // Assert
        Assert.That(numberOfContainingBoxes.GetNumberOfContainingBoxes, Is.EqualTo(1));
    }

    [Test]
    public void BoxFactoryShouldDeliverEightBoxes()
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act
        var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(8);

        // Assert
        Assert.That(numberOfContainingBoxes.GetNumberOfContainingBoxes, Is.EqualTo(8));
    }

    [Test]
    public void BoxFactoryShouldDeliverFiveBoxes()
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act
        var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(5);

        // Assert
        Assert.That(numberOfContainingBoxes.GetNumberOfContainingBoxes, Is.EqualTo(5));
    }

    [TestCase(1)]
    [TestCase(2)]
    [TestCase(5)]
    [TestCase(8)]
    [TestCase(20)]
    public void FactoryBoxShouldPhysicallyContainRequestedNumberOfBoxes(int requestedBoxes)
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act
        var box = boxFactory.CreateBoxWithContainingBoxes(requestedBoxes);

        // Assert
        Assert.That(CountPhysicallyNestedBoxes(box), Is.EqualTo(requestedBoxes),
            "the returned box should physically nest the requested number of boxes, not just report it");
    }

    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-100)]
    public void FactoryShouldThrowForNonPositiveCounts(int requestedBoxes)
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act / Assert
        Assert.That(() => boxFactory.CreateBoxWithContainingBoxes(requestedBoxes),
            Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}