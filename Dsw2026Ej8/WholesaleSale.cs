using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal cuentaTotal) : base(cuentaTotal) { }
        public override decimal CalculateTotal()
        {
            return CuentaTotal * 0.9m;
        }
    }
}
