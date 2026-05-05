using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio (int? nota1, int? nota2, int? nota3)
        {
            double sumanota = 0;
            int numnotas = 0;

            if (nota1.HasValue && nota1.Value < 0 && nota1.Value > 10) { sumanota =+ nota1.Value; numnotas++; }
            if (nota2.HasValue && nota2.Value < 0 && nota2.Value > 10) { sumanota = +nota2.Value; numnotas++; }
            if (nota3.HasValue && nota3.Value < 0 && nota3.Value > 10) { sumanota = +nota3.Value; numnotas++; }
            
            if (numnotas == 0) { return 0; }

            return sumanota/numnotas;

        }
    }
}
