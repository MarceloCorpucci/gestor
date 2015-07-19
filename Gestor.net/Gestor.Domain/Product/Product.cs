using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestor.Domain {
    public class Product {
        public int Id { get; set; }
        public string SupplierProductCode { get; set; }
        public string MainDescription { get; set; }
        public string SecondaryDescription { get; set; }
        public string Comments { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool isActive { get; set; }
    }
}
