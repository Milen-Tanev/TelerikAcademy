using System.Collections.Generic;

using NUnit.Framework;
using Moq;

using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Enums;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Counstructor_Should
    {
        [TestCase("P")]
        [TestCase("Package")]
        [TestCase("Valid Package")]
        public void SetParametersCorrectly(string name)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();

            // Act
            Package package = new Package(name, mockPackageVersion.Object);

            // Assert
            Assert.AreEqual(name, package.Name);
            Assert.AreSame(mockPackageVersion.Object, package.Version);
        }

        [TestCase("P")]
        [TestCase("Package")]
        [TestCase("Valid Package")]
        public void SetNameOfCorrectType(string name)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();

            // Act
            Package package = new Package(name, mockPackageVersion.Object);

            // Assert
            Assert.IsInstanceOf<IVersion>(package.Version);
        }

        [Test]
        public void SetVersionOfCorrectType()
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();

            // Act
            Package package = new Package("Pesho", mockPackageVersion.Object);

            // Assert
            Assert.IsInstanceOf<IVersion>(package.Version);
        }

        [Test]
        public void SetDependenciesCorrectlyForOptionalParameter()
        {
            // Arrange
            var name = "Pesho";
            var mockPackageVersion = new Mock<IVersion>();

            // Act
            Package package = new Package(name, mockPackageVersion.Object);

            // Assert
            Assert.IsInstanceOf<HashSet<IPackage>>(package.Dependencies);
        }

        [Test]
        public void SetDependenciesCorrectlyForGivenParameter()
        {
            // Arrange
            var name = "Pesho";
            var mockPackageVersion = new Mock<IVersion>();
            var mockIPackage = new Mock<IPackage>();
            var dependencies = new HashSet<IPackage>();

            // Act
            dependencies.Add(mockIPackage.Object);
            Package package = new Package(name, mockPackageVersion.Object, dependencies);

            // Assert
            Assert.AreEqual(1, package.Dependencies.Count);
        }
    }
}
