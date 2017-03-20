using NUnit.Framework;
using Moq;

using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class Properties_Should
    {
        [TestCase("Valid project", "Sofia")]
        [TestCase("Random project", "Telerik Academy's building")]
        [TestCase("Pesho's project", "Vraca")]
        public void SetNameCorrectly(string name, string location)
        {
            // Arrange
            var mockRepository = new Mock<IRepository<IPackage>>();

            // Act
            Project project = new Project(name, location, mockRepository.Object);

            // Assert
            Assert.AreEqual(name, project.Name);
        }

        [TestCase("Valid project", "Sofia")]
        [TestCase("Random project", "Telerik Academy's building")]
        [TestCase("Pesho's project", "Vraca")]
        public void SetLocationCorrectly(string name, string location)
        {
            // Arrange
            var mockRepository = new Mock<IRepository<IPackage>>();

            // Act
            Project project = new Project(name, location, mockRepository.Object);

            // Assert
            Assert.AreEqual(location, project.Location);
        }
    }
}
