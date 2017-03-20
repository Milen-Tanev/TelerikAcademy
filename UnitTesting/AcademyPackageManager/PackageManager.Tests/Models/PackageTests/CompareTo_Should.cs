using System;

using Moq;
using NUnit.Framework;

using PackageManager.Enums;
using PackageManager.Models;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class CompareTo_Should
    {
        [TestCase(int.MaxValue, 0, 5984, VersionType.alpha)]
        [TestCase(0, int.MaxValue, 5984, VersionType.beta)]
        [TestCase(12312, 5984, int.MaxValue, VersionType.final)]
        [TestCase(6546457, 124151, 0, VersionType.rc)]
        public void ReturnCorrectAnswerWithValidOtherWhenEqual(int major, int minor, int patch, VersionType type)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(major);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(minor);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(patch);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(type);

            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            IPackage other = new Package("Pesho", mockPackageVersion.Object);

            // Act
            var result = package.CompareTo(other);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestCase(int.MaxValue, 0, 5984, VersionType.alpha,
                (int.MaxValue - 1), 0, 5984, VersionType.alpha)]
        [TestCase(0, int.MaxValue, 5984, VersionType.beta,
                0, (int.MaxValue - 1), 5984, VersionType.beta)]
        [TestCase(12312, 5984, int.MaxValue, VersionType.final,
                12312, 5984, (int.MaxValue - 1), VersionType.final)]
        [TestCase(6546457, 124151, 0, VersionType.rc,
                6546457, 124151, 0, VersionType.alpha)]
        public void ReturnCorrectAnswerWithValidOtherWhenFirstIsBigger(int major, int minor, int patch, VersionType type,
                        int otherMajor, int otherMinor, int otherPatch, VersionType otherType)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(major);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(minor);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(patch);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(type);

            var mockOther = new Mock<IVersion>();
            mockOther.Setup(ver => ver.Major).Returns(otherMajor);
            mockOther.Setup(ver => ver.Minor).Returns(otherMinor);
            mockOther.Setup(ver => ver.Patch).Returns(otherPatch);
            mockOther.Setup(ver => ver.VersionType).Returns(otherType);

            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            IPackage other = new Package("Pesho", mockOther.Object);

            // Act
            var result = package.CompareTo(other);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestCase(int.MaxValue, 0, 5984, VersionType.alpha,
                (int.MaxValue - 1), 0, 5984, VersionType.alpha)]
        [TestCase(0, int.MaxValue, 5984, VersionType.beta,
                0, (int.MaxValue - 1), 5984, VersionType.beta)]
        [TestCase(100, 50, int.MaxValue, VersionType.final,
                100, 50, (int.MaxValue - 1), VersionType.final)]
        [TestCase(100, 50, 0, VersionType.alpha,
                100, 50, 0, VersionType.rc)]
        public void ReturnCorrectAnswerWithValidOtherWhenFirstIsSmaller(int major, int minor, int patch, VersionType type,
                int otherMajor, int otherMinor, int otherPatch, VersionType otherType)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(major);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(minor);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(patch);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(type);

            var mockOther = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(otherMajor);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(otherMinor);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(otherPatch);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(otherType);

            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            IPackage other = new Package("Pesho", mockOther.Object);

            // Act
            var result = other.CompareTo(package);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void ThrowArgumentNullExceptionWhenOtherIsNull()
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(50);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(50);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(50);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(VersionType.beta);

            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            IPackage other = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => package.CompareTo(other));
        }

        [Test]
        public void ThrowArgumentExceptionWhenOtherNameIsDifferent()
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(50);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(50);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(50);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(VersionType.beta);

            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            IPackage other = new Package("Gosho", mockPackageVersion.Object);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => package.CompareTo(other));
        }
    }
}
