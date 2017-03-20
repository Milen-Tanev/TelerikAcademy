using System;

using Moq;
using NUnit.Framework;

using PackageManager.Info.Contracts;
using PackageManager.Repositories;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Mocks.Repositories;
using PackageManager.Enums;
using PackageManager.Models;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void ThrowArgumentNullExceptionWhenPackageIsNull()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var packageRepository = new PackageRepository(mockLogger.Object);
            IPackage package = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => packageRepository.Add(package));
        }

        [Test]
        public void AddPackageWhenCorrectIsAddedPackage()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var mockPackage = new Mock<IPackage>();
            var packageRepository = new MockPackageRepository(mockLogger.Object);

            // Act
            packageRepository.Add(mockPackage.Object);

            // Assert
            Assert.AreEqual(1, packageRepository.Packages.Count);
        }

        [Test]
        public void ShouldNotAddPackageWhenAlreadyExists()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var mockPackage = new Mock<IPackage>();
            var packageRepository = new MockPackageRepository(mockLogger.Object);

            // Act
            packageRepository.Add(mockPackage.Object);
            packageRepository.Add(mockPackage.Object);

            // Assert
            Assert.AreEqual(1, packageRepository.Packages.Count);
        }

        [Test]
        public void ShouldNotAddNewPackageWithButUpdateCurrentWithHigherVersion()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var mockVersionExisting = new Mock<IVersion>();
            var mockVersionNew = new Mock<IVersion>();
            var packageRepository = new MockPackageRepository(mockLogger.Object);

            // Act
            mockVersionExisting.SetupGet(v => v.Major).Returns(1);
            mockVersionExisting.SetupGet(v => v.Minor).Returns(1);
            mockVersionExisting.SetupGet(v => v.Patch).Returns(1);
            mockVersionExisting.SetupGet(v => v.VersionType).Returns(VersionType.alpha);

            mockVersionNew.SetupGet(v => v.Major).Returns(100);
            mockVersionNew.SetupGet(v => v.Minor).Returns(100);
            mockVersionNew.SetupGet(v => v.Patch).Returns(100);
            mockVersionNew.SetupGet(v => v.VersionType).Returns(VersionType.final);

            var existingPackage = new Package("Pesho", mockVersionExisting.Object);

            var newPackage = new Package("Pesho", mockVersionNew.Object);

            // Act
            packageRepository.Add(existingPackage);
            packageRepository.Add(newPackage);

            // Assert
            Assert.AreEqual(1, packageRepository.Packages.Count);
        }

        [Test]
        public void ShouldUpdatePackageWithLowerVersion()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var mockVersionExisting = new Mock<IVersion>();
            var mockVersionNew = new Mock<IVersion>();
            var packageRepository = new MockPackageRepository(mockLogger.Object);

            // Act
            mockVersionExisting.SetupGet(v => v.Major).Returns(1);
            mockVersionExisting.SetupGet(v => v.Minor).Returns(1);
            mockVersionExisting.SetupGet(v => v.Patch).Returns(1);
            mockVersionExisting.SetupGet(v => v.VersionType).Returns(VersionType.alpha);

            mockVersionNew.SetupGet(v => v.Major).Returns(100);
            mockVersionNew.SetupGet(v => v.Minor).Returns(100);
            mockVersionNew.SetupGet(v => v.Patch).Returns(100);
            mockVersionNew.SetupGet(v => v.VersionType).Returns(VersionType.final);

            var existingPackage = new Package("Pesho", mockVersionExisting.Object);

            var newPackage = new Package("Pesho", mockVersionNew.Object);

            // Act
            packageRepository.Add(existingPackage);
            packageRepository.Add(newPackage);

            IVersion version = existingPackage.Version;
            foreach (var item in packageRepository.Packages)
            {
                version = item.Version;
            }

            // Assert
            Assert.AreEqual(newPackage.Version, version);
        }
    }
}
