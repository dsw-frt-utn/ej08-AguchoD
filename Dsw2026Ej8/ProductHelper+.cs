using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal partial class ProductHelper
    {
        public string ConversorMoneda(decimal price) => price.ToString("C");
    }
}
