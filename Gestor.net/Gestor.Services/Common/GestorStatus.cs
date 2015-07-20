using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestor.Services.Common {
    public class GestorStatus {
        public bool HasErrors { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorContext { get; set; }
    }
}
