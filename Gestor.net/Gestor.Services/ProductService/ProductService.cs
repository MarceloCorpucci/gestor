using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestor.Services.Common;
using Gestor.Infrastructure;
using Gestor.Domain;

namespace Gestor.Services {
    public class ProductService {
        private ProductRepository repository;

        public ProductService(ProductRepository repository) {
            this.repository = repository;
        }

        public GestorStatus Save(List<Product> products) {
            foreach (var product in products) {
              //repository.Save(product);
            }

            return null;
        }
    }
}
