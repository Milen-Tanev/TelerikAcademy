using System;
using NUnit.Framework;

using PackageManager.Models;
using PackageManager.Enums;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class Properties_Should
    {
        [TestCase(int.MaxValue, 15, 32, VersionType.alpha)]
        [TestCase(0, 0, 25, VersionType.beta)]
        [TestCase(10000, 20000, 0, VersionType.final)]
        [TestCase(int.MaxValue, 15, int.MaxValue, VersionType.rc)]

        public void SetCorrectValuesToMajor(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageVersion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.AreEqual(major, packageVersion.Major);
        }

        [TestCase(int.MaxValue, 15, 32, VersionType.alpha)]
        [TestCase(0, 0, 25, VersionType.beta)]
        [TestCase(200000, 20000, 0, VersionType.final)]
        [TestCase(15, 15, int.MaxValue, VersionType.rc)]
        public void SetCorrectValuesToMinor(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageVersion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.AreEqual(minor, packageVersion.Minor);
        }

        [TestCase(int.MaxValue, 15, 32, VersionType.alpha)]
        [TestCase(0, 0, 25, VersionType.beta)]
        [TestCase(200000, 20000, 0, VersionType.final)]
        [TestCase(15, 15, int.MaxValue, VersionType.rc)]
        public void SetCorrectValuesToPatch(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageVersion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.AreEqual(patch, packageVersion.Patch);
        }

        [TestCase(int.MaxValue, 15, 32, VersionType.alpha)]
        [TestCase(0, 0, 25, VersionType.beta)]
        [TestCase(200000, 20000, 0, VersionType.final)]
        [TestCase(15, 15, int.MaxValue, VersionType.rc)]
        public void SetCorrectToVersionType(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageVersion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.AreEqual(type, packageVersion.VersionType);
        }

        [TestCase(int.MinValue, 15, 32, VersionType.alpha)]
        [TestCase(-50, 0, 25, VersionType.beta)]
        [TestCase(-200000, 20000, 0, VersionType.final)]
        [TestCase(-1, 15, int.MaxValue, VersionType.rc)]
        public void ThrowArgumentExceptionWhenInvalidMajorIsGiven(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, type));
        }

        [TestCase(55, int.MinValue, 32, VersionType.alpha)]
        [TestCase(55, -50, 25, VersionType.beta)]
        [TestCase(55, -200000, 0, VersionType.final)]
        [TestCase(55, -1, int.MaxValue, VersionType.rc)]
        public void ThrowArgumentExceptionWhenInvalidMinorIsGiven(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, type));
        }

        [TestCase(55, 55, int.MinValue, VersionType.alpha)]
        [TestCase(55, 55, -50, VersionType.beta)]
        [TestCase(55, 55, -200000, VersionType.final)]
        [TestCase(55, 55, -1, VersionType.rc)]
        public void ThrowArgumentExceptionWhenInvalidPatchIsGiven(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, type));
        }

        [TestCase(55, 55, 55, 100)]
        [TestCase(55, 55, 55, -55)]
        [TestCase(55, 55, 55, 'Щ')]
        [TestCase(55, 55, 55, 1231)]
        public void ThrowArgumentExceptionWhenInvalidPackageTypeIsGiven(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, type));
        }
    }
}
