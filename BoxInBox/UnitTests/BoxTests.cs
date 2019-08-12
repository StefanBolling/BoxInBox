using BoxInBox;
using NUnit.Framework;

namespace Tests
{
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
            var numberOfContainingBoxes = boxWithOneContainedBox.GetNumberOfContaintingBoxes;

            // Assert
            Assert.AreEqual(1, numberOfContainingBoxes);
        }

        [Test]
        public void BoxWithFourBoxShouldSayItContainsFourBoxes()
        {
            // Arrange
            var boxWithOneContainedBox = new Box { ContainedBox = new Box() };
            var boxWithTwocontainingBoxes = new Box() { ContainedBox = boxWithOneContainedBox };
            var boxWithThreeContainingBoxes = new Box() { ContainedBox = boxWithTwocontainingBoxes };
            var boxWithFourContainingBoxes = new Box() { ContainedBox = boxWithThreeContainingBoxes };

            // Act
            var numberOfContainingBoxes = boxWithFourContainingBoxes.GetNumberOfContaintingBoxes;

            // Assert
            Assert.AreEqual(4, numberOfContainingBoxes);
        }
    }
}