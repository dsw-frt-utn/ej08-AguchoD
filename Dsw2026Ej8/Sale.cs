using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal CuentaTotal { get; set; }

        protected Sale (decimal cuentaTotal) { CuentaTotal = cuentaTotal}

        virtual public decimal CalculateTotal() { return CuentaTotal; }
    }
}
