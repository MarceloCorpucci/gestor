using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Gestor.Domain;

namespace Gestor.Tests {

    [TestFixture]
    public class ProductServiceTest {
        private Product product;

        [SetUp]
        public void SetUp() {
            product = new Product();
            product.SupplierProductCode = "ABC123";
            product.MainDescription = "Dummy product";
            product.CreationDate = new DateTime(2015, 01, 01);
            product.ModificationDate = new DateTime(2015, 01, 01);
            product.isActive = true;

        }

        [Test]
        public void SaveProduct() {
            
        }
    }
}
