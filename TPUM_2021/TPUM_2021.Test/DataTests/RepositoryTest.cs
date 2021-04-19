using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPUM_2021.Data.Model;

namespace TPUM_2021.Test.DataTests
{
    [TestFixture]
    internal class RepositoryTest
    {
        private static readonly List<Product> _threeProductsList = new List<Product>
        {
            new Product {Id = 1, CustomerId = null, Name = "p1", Price = 1},
            new Product {Id = 2, CustomerId = null, Name = "p2", Price = 2},
            new Product {Id = 3, CustomerId = null, Name = "p3", Price = 3}
        };

        private static readonly object[] _deleteProductTestTestSource =
        {
            new TestCaseData(
                _threeProductsList,
                3,
                _threeProductsList.GetRange(0, 2))
                .SetName("DeleteTheLastProduct_ListOfProducts_IndexToDelete_ResultList")
        };

        [TestCaseSource(nameof(_deleteProductTestTestSource))]
        public void DeleteProductTest(List<Product> products, int index, List<Product> expectedResult)
        {
            // Arrange
            var context = new Data.AppContext();
            context[typeof(Product)] = products;

            var repositoryMock = new Mock<Data.Repository<Product>>(context) { CallBase = true };

            // Act
            repositoryMock.Object.Delete(index);

            // Assert
            Assert.AreEqual(context[typeof(Product)].ToList().Count, expectedResult.Count);
            Assert.IsTrue(context[typeof(Product)].SequenceEqual(expectedResult));
        }
    }
}
