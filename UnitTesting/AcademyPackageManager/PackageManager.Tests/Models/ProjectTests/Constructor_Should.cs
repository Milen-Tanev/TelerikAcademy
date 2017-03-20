using NUnit.Framework;
using Moq;

using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using PackageManager.Repositories.Contracts;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase("Valid project", "Sofia")]
        [TestCase("Random project", "Telerik Academy's building")]
        [TestCase("Pesho's project", "Vraca")]
        public void SetAppropriatePassedValues(string name, string location)
        {
            // Arrange
            var mockRepository = new Mock<IRepository<IPackage>>();

            // Act
            Project project = new Project(name, location, mockRepository.Object);

            // Assert
            Assert.AreEqual(name, project.Name);
            Assert.AreEqual(location, project.Location);
        }

        [TestCase("Valid project", "Sofia")]
        [TestCase("Random project", "Telerik Academy's building")]
        [TestCase("Pesho's project", "Vraca")]
        public void SetAppropriateTypes(string name, string location)
        {
            // Arrange
            var mockRepository = new Mock<IRepository<IPackage>>();

            // Act
            Project project = new Project(name, location, mockRepository.Object);

            // Assert
            Assert.IsInstanceOf<string>(project.Name);
            Assert.IsInstanceOf<string>(project.Location);
        }

        [Test]
        public void SetPackageRepositoryCorrectlyForOptionalParameter()
        {
            // Arrange & Act
            Project project = new Project("Valid project", "Valid town");

            // Assert
            Assert.IsInstanceOf<PackageRepository>(project.PackageRepository);
        }

        [Test]
        public void SetPackageRepositoryCorrectlyForPassedParameter()
        {
            // Arrange
            var mockRepository = new Mock<IRepository<IPackage>>();
            
            // Arrange & Act
            Project project = new Project("Valid project", "Valid town", mockRepository.Object);

            // Assert
            Assert.AreEqual(mockRepository.Object, project.PackageRepository);
        }
    }
}
