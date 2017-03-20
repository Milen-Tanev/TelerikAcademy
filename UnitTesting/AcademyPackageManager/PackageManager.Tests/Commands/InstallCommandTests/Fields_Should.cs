using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Mocks.Commands;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    public class Fields_Should
    {
        [Test]
        public void BeCorrectValueInstaller()
        {
            // Arrange
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            // Act
            MockInstallCommand command = new MockInstallCommand(installer.Object, package.Object);

            // Assert
            Assert.AreEqual(installer.Object, command.Installer);
        }

        public void BeCorrectValuePackage()
        {
            // Arrange
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            // Act
            MockInstallCommand command = new MockInstallCommand(installer.Object, package.Object);

            // Assert
            Assert.AreEqual(package.Object, command.Package);
        }
    }
}
