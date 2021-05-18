using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TPUM_2021.ClientLogic;
using TPUM_2021.CommonData;
using TPUM_2021.CommonData.Model;
using TPUM_2021.CommonLogic;

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

        private static readonly ProductDto[] _threeProductsDtoList = new ProductDto[]
        {
            new ProductDto {Id = 1, CustomerId = null, Name = "p1", Price = 1},
            new ProductDto {Id = 2, CustomerId = null, Name = "p2", Price = 2},
            new ProductDto {Id = 3, CustomerId = null, Name = "p3", Price = 3}
        };

        private static readonly object[] _productQueryTestTestSource =
        {
            new TestCaseData(
                _threeProductsList,
                _threeProductsDtoList,
                false)
                .SetName("GetAvitableProducts_ListOfProducts_ResultList_NoException"),
        };



        [TestCaseSource(nameof(_productQueryTestTestSource))]
        public void GetProductQueryTest(Product[] products, ProductDto[] expectedResult, bool exceptionExpected)
        {
            // Arrange

            var repositoryMock = new Mock<ClientData.Repository>(null);

            IEnumerable<ProductDto> result = null;

            repositoryMock.Setup(m => m.GetAsync<IProduct>(It.IsAny<Expression<Func<IProduct, bool>>>())).Returns(Task.FromResult(products.AsEnumerable<IProduct>()));

            var productQueryMock = new Mock<ProductQuery>(new Mapper(), repositoryMock.Object);


            // Act
            try
            {
                result = productQueryMock.Object.GetAvailableProductsAsync().Result;
            }
            catch (InvalidOperationException ex)
            {
                Assert.IsTrue(exceptionExpected && ex.GetType() == typeof(InvalidOperationException));
            }

            // Assert
            Assert.AreEqual(result.ToList().Count, expectedResult.Length);
            Assert.IsTrue(result.SequenceEqual(expectedResult, new ProductDtoEqualityComparer()));
        }

        private class ProductDtoEqualityComparer : IEqualityComparer<ProductDto>
        {
            public bool Equals(ProductDto x, ProductDto y)
            {
                return x.Id == y.Id && x.Name == y.Name && x.Price == y.Price && x.CustomerId == y.CustomerId;
            }

            public int GetHashCode(ProductDto obj)
            {
                return obj.Id.GetHashCode() ^ obj.Name.GetHashCode() ^ obj.Price.GetHashCode() ^ obj.CustomerId.GetHashCode();
            }
        }
    }
}