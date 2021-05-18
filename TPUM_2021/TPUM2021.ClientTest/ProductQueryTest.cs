using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TPUM_2021.CommonData;
using TPUM_2021.CommonData.Model;

namespace TPUM_2021.ClientTest
{
    [TestFixture]
    internal class ProductQueryTest
    {
        private static readonly Product[] _threeProductsList = new Product[]
        {
            new Product {Id = 1, CustomerId = null, Name = "p1", Price = 1},
            new Product {Id = 2, CustomerId = null, Name = "p2", Price = 2},
            new Product {Id = 3, CustomerId = null, Name = "p3", Price = 3}
        };

        private static readonly object[] _deleteProductsTestTestSource =
        {
            new TestCaseData(
                _threeProductsList,
                new int[] { 3 },
                new Product[]{ _threeProductsList[0], _threeProductsList[1] },
                false)
                .SetName("DeleteTheLastProduct_ListOfProducts_IndexToDelete_ResultList_NoException"),
            new TestCaseData(
                _threeProductsList,
                new int[] { 4 },
                _threeProductsList,
                true)
                .SetName("DeleteProductNotInTheList_ListOfProducts_IndexToDelete_ResultList_Exception"),
            new TestCaseData(
                _threeProductsList,
                new int[] { 1, 2, 3 },
                new Product[] { },
                false)
                .SetName("DeleteAllProducts_ListOfProducts_IndicesToDelete_ResultList_NoException"),
            new TestCaseData(
                _threeProductsList,
                new int[] { },
                _threeProductsList,
                false)
                .SetName("DeleteNoProducts_ListOfProducts_IndicesToDelete_ResultList_NoException")
        };



        [TestCaseSource(nameof(_deleteProductsTestTestSource))]
        public void DeleteProductsTest(Product[] products, int[] indices, Product[] expectedResult, bool exceptionExpected)
        {
            // Arrange

            var repositoryMock = new Mock<ClientData.Repository>();

            repositoryMock.Setup(m => m.GetAsync<It.IsAnyType>(It.IsAny<It.IsAnyType>())).Returns(products);

            // Act
            try
            {
                foreach (int index in indices)
                {
                    repositoryMock.Object.Delete<Product>(index);
                }
            }
            catch (InvalidOperationException ex)
            {
                Assert.IsTrue(exceptionExpected && ex.GetType() == typeof(InvalidOperationException));
            }

            // Assert
            Assert.AreEqual(context[typeof(Product)].ToList().Count, expectedResult.Length);
            Assert.IsTrue(context[typeof(Product)].SequenceEqual(expectedResult));
        }

    }
}