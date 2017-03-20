using NUnit.Framework;
using Moq;

using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Enums;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Properties_Should
    {
        [TestCase("P")]
        [TestCase("Package")]
        [TestCase("Valid Package")]
        public void SetNameCorrectly(string name)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();

            // Act
            Package package = new Package(name, mockPackageVersion.Object);

            // Assert
            Assert.AreEqual(name, package.Name);
        }

        [Test]
        public void SetVersionCorrectly()
        {
            // Arrange
            var name = "Pesho";
            var mockPackageVersion = new Mock<IVersion>();

            // Act
            Package package = new Package(name, mockPackageVersion.Object);

            // Assert
            Assert.AreSame(mockPackageVersion.Object, package.Version);
        }

        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta)]
        [TestCase(20320, 1500, 300, VersionType.final)]
        [TestCase(3145, 12414, 75, VersionType.rc)]
        public void SetUrlCorrectly(int major, int minor, int patch, VersionType type)
        {
            // Arrange
            var name = "Pesho";
            var packageVersion = new PackageVersion(major, minor, patch, type);

            // Act
            Package package = new Package(name, packageVersion);

            var expectedResult = string.Format("{0}.{1}.{2}-{3}", major, minor, patch, type);

            // Assert
            Assert.AreEqual(expectedResult, package.Url);
        }
    }
}
