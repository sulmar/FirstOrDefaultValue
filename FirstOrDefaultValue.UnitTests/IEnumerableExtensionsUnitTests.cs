using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FirstOrDefaultValue.UnitTests
{
    [TestClass]
    public class IEnumerableExtensionsUnitTests
    {
        [TestMethod]
        public void FirstOrDefault_Found_ShouldReturnsFirstValue()
        {
            // Arrange
            var arr2 = Enumerable.Range(0, 10);

            // Act
            var result = arr2.FirstOrDefault(x => x > 1, -1);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FirstOrDefault_NotFound_ShouldReturnsDefaultValue()
        {
            // Arrange
            var array = Enumerable.Range(0, 10);

            // Act
            var result = array.FirstOrDefault(x => x > 11, -1);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SingleOrDefault_Found_ShouldReturnsSingleValue()
        {
            // Arrange
            var array = Enumerable.Range(0, 10);

            // Act
            var result = array.SingleOrDefault(x => x > 8, -1);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void SingleOrDefault_NotFound_ShouldReturnsDefaultValue()
        {
            // Arrange
            var array = Enumerable.Range(0, 10);

            // Act
            var result = array.SingleOrDefault(x => x > 10, -1);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void LastOrDefault_Found_ShouldReturnsSingleValue()
        {
            // Arrange
            var array = Enumerable.Range(0, 10);

            // Act
            var result = array.LastOrDefault(x => x > 1, -1);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void LastOrDefault_NotFound_ShouldReturnsDefaultValue()
        {
            // Arrange
            var array = Enumerable.Range(0, 10);

            // Act
            var result = array.LastOrDefault(x => x > 10, -1);

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
