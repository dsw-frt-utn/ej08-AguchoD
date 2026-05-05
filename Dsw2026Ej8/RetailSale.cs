using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {
        public RetailSale(decimal cuentaTotal) : base(cuentaTotal) { }
        public override decimal CalculateTotal()
        {
            return CuentaTotal;
        }
    }
}
