using Moq;
using NUnit.Framework;

using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

using PackageManager.Tests.Mocks.Commands;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    public class Constructor_Should
    {
        //public InstallCommand(IInstaller<IPackage> installer, IPackage package)
        [Test]
        public void SetTheAppropriatePassedValues()
        {
            // Arrange
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            // Act
            MockInstallCommand command = new MockInstallCommand(installer.Object, package.Object);

            // Assert
            Assert.AreEqual(installer.Object, command.Installer);
            Assert.AreEqual(package.Object, command.Package);
        }

        [Test]
        public void SetTheAppropriateTypes()
        {
            // Arrange
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            // Act
            MockInstallCommand command = new MockInstallCommand(installer.Object, package.Object);

            // Assert
            Assert.AreEqual(installer.Object.GetType(), command.Installer.GetType());
            Assert.AreEqual(package.Object.GetType(), command.Package.GetType());
        }
    }
}
