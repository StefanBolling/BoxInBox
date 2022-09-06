using BoxInBox;
using NUnit.Framework;

namespace UnitTests;

public class BoxFactoryTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BoxFactoryShouldDeliverOneBox()
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act
        var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(1);

        // Assert
        Assert.AreEqual(1, numberOfContainingBoxes.GetNumberOfContainingBoxes);
    }

    [Test]
    public void BoxFactoryShouldDeliverEightBoxes()
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act
        var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(8);

        // Assert
        Assert.AreEqual(8, numberOfContainingBoxes.GetNumberOfContainingBoxes);
    }

    [Test]
    public void BoxFactoryShouldDeliverFiveBoxes()
    {
        // Arrange
        var boxFactory = new BoxFactory();

        // Act
        var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(5);

        // Assert
        Assert.AreEqual(5, numberOfContainingBoxes.GetNumberOfContainingBoxes);
    }
}