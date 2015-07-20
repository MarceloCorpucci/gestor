using System;
using System.Collections.Generic;
using NUnit.Framework;
using Gestor.Domain;
using Gestor.Infrastructure;
using Gestor.Services;
using Rhino.Mocks;

namespace Gestor.Tests {

    [TestFixture]
    public class ProductServiceTest {
        List<Product> dummyProducts;

        [SetUp]
        public void SetUp() {
            dummyProducts = new List<Product>();
            
            Product product = new Product();
            product.SupplierProductCode = "ABC123";
            product.MainDescription = "Dummy product";
            product.CreationDate = new DateTime(2015, 01, 01);
            product.ModificationDate = new DateTime(2015, 01, 01);
            product.isActive = true;

            dummyProducts.Add(product);
        }

        [Test]
        public void TestSaveProduct() {
            var stubProductRepo = MockRepository.GenerateStub<ProductRepository>();
            var service = new ProductService(stubProductRepo);
            var result = service.SaveProduct(dummyProducts);

            Assert.False(result.HasErrors);
        }
    }
}
