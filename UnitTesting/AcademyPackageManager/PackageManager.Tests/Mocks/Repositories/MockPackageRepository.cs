using System.Collections.Generic;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using PackageManager.Repositories.Contracts;

namespace PackageManager.Tests.Mocks.Repositories
{
    class MockPackageRepository : PackageRepository, IRepository<IPackage>
    {
        public MockPackageRepository(ILogger logger, ICollection<IPackage> packages = null) 
                : base(logger, packages)
        {
        }
        public ICollection<IPackage> Packages { get { return this.packages; } }
    }
}
