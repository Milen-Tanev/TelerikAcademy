using Moq;
using NUnit.Framework;

using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Mocks.Commands;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    public class Properties_Should
    {
        [Test]
        public void SetRightValueForOperation()
        {
            // Arrange
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();
            var expected = InstallerOperation.Install;

            // Act
            MockInstallCommand command = new MockInstallCommand(installer.Object, package.Object);

            // Assert
            Assert.AreEqual(expected, command.Installer.Operation);
        }

    }
}
