using System;

using NUnit.Framework;
using Moq;

using PackageManager.Enums;
using PackageManager.Models;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Equals_Should
    {
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta)]
        [TestCase(int.MaxValue, 0, 54213, VersionType.final)]
        [TestCase(123123, 543543, int.MaxValue, VersionType.rc)]
        public void ReturnEqualWhenValidEqualParameterIsGiven(int major, int minor, int patch, VersionType type)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(major);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(minor);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(patch);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(type);

            IPackage package = new Package("Pesho", mockPackageVersion.Object); 
            IPackage obj = new Package("Pesho", mockPackageVersion.Object);

            // Act
            var result = package.Equals(obj);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, VersionType.alpha,
                (int.MaxValue - 1), int.MaxValue, int.MaxValue, VersionType.alpha)]
        [TestCase(0, 0, 0, VersionType.beta,
                0, 1, 0, VersionType.beta)]
        [TestCase(int.MaxValue, 0, 54213, VersionType.final,
                int.MaxValue, 0, 54212, VersionType.final)]
        [TestCase(123123, 543543, int.MaxValue, VersionType.rc,
            123123, 543543, int.MaxValue, VersionType.final)]
        public void ReturnNotEqualWhenValidNotEqualParameterIsGiven(int major, int minor, int patch, VersionType type,
                        int objMajor, int objMinor, int objPatch, VersionType objType)
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(major);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(minor);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(patch);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(type);

            var objPackageVersion = new Mock<IVersion>();
            mockPackageVersion.Setup(ver => ver.Major).Returns(objMajor);
            mockPackageVersion.Setup(ver => ver.Minor).Returns(objMinor);
            mockPackageVersion.Setup(ver => ver.Patch).Returns(objPatch);
            mockPackageVersion.Setup(ver => ver.VersionType).Returns(objType);

            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            IPackage obj = new Package("Pesho", objPackageVersion.Object);

            // Act
            var result = package.Equals(obj);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void TestIfPassedArgumentIsIPackage()
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();

            var package = new Package("Pesho", mockPackageVersion.Object);
            var obj = new Package("Pesho", mockPackageVersion.Object);

            // Act
            package.Equals(obj);

            // Assert
            Assert.IsInstanceOf<IPackage>(obj);
        }

        [Test]
        public void AThrowrgumentNullExceptionWhenObjIsNull()
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            IPackage obj = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => package.Equals(obj));
        }

        [Test]
        public void ThrowrgumentExceptionWhenObjIsNotIPackage()
        {
            // Arrange
            var mockPackageVersion = new Mock<IVersion>();
            IPackage package = new Package("Pesho", mockPackageVersion.Object);
            var obj = "I am not an IPackage";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => package.Equals(obj));
        }
    }
}
