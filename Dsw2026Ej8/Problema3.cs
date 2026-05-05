using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias (int originalValue, Product product)
        {
            int copiaValor = originalValue;
            copiaValor++;
            Product copiaProducto = product;
            copiaProducto.DescripcionActual("Nuevo");
            return $"{originalValue}-{copiaValor}-{copiaProducto.Description}";
        }
    }
}
