using NUnit.Framework;

using PackageManager.Models;
using PackageManager.Enums;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta)]
        [TestCase(10000, 5000, 100000, VersionType.final)]
        [TestCase(0, 100, 1000, VersionType.rc)]
        public void SetAppropriatePassedValues(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageversion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.AreEqual(major, packageversion.Major);
            Assert.AreEqual(minor, packageversion.Minor);
            Assert.AreEqual(patch, packageversion.Patch);
            Assert.AreEqual(type, packageversion.VersionType);
        }

        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta)]
        [TestCase(10000, 5000, 100000, VersionType.final)]
        public void SetAppropriateTypesForMajor(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageversion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.IsInstanceOf<int>(packageversion.Major);
        }

        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta)]
        [TestCase(10000, 5000, 100000, VersionType.final)]
        public void SetAppropriateTypesForMinor(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageversion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.IsInstanceOf<int>(packageversion.Minor);
        }

        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta)]
        [TestCase(10000, 5000, 100000, VersionType.final)]
        public void SetAppropriateTypesForPatch (int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageversion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.IsInstanceOf<int>(packageversion.Patch);
        }

        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta)]
        [TestCase(10000, 5000, 100000, VersionType.final)]
        public void SetAppropriateTypesForVersionType(int major, int minor, int patch, VersionType type)
        {
            // Arrange & Act
            PackageVersion packageversion = new PackageVersion(major, minor, patch, type);

            // Assert
            Assert.IsInstanceOf<VersionType>(packageversion.VersionType);
        }
    }
}
