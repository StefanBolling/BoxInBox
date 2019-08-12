using BoxInBox;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
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
            Assert.AreEqual(1, numberOfContainingBoxes.GetNumberOfContaintingBoxes);
        }

        [Test]
        public void BoxFactoryShouldDeliverEightBoxes()
        {
            // Arrange
            var boxFactory = new BoxFactory();

            // Act
            var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(8);

            // Assert
            Assert.AreEqual(8, numberOfContainingBoxes.GetNumberOfContaintingBoxes);
        }

        [Test]
        public void BoxFactoryShouldDeliverFiveBoxes()
        {
            // Arrange
            var boxFactory = new BoxFactory();

            // Act
            var numberOfContainingBoxes = boxFactory.CreateBoxWithContainingBoxes(5);

            // Assert
            Assert.AreEqual(5, numberOfContainingBoxes.GetNumberOfContaintingBoxes);
        }
    }
}