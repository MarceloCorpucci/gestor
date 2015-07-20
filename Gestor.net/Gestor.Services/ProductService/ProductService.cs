using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestor.Services.Common;
using Gestor.Infrastructure;
using Gestor.Domain;

namespace Gestor.Services {
    public class ProductService {

        public ProductService(ProductRepository repository) {
        }

        public GestorStatus SaveProduct(List<Product> products) {
            return null;
        }
    }
}
