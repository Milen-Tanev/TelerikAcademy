using PackageManager.Commands;
using PackageManager.Commands.Contracts;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Mocks.Commands
{
    internal class MockInstallCommand : InstallCommand, ICommand
    {
        public MockInstallCommand(IInstaller<IPackage> installer, IPackage package) 
            : base(installer, package)
        {
        }

        public IInstaller<IPackage> Installer { get { return this.installer; } }

        public IPackage Package { get { return this.package; } }
    }
}
