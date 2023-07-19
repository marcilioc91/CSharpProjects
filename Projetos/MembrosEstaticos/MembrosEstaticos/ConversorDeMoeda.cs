using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double ValorDolar(double valorCotacao, double qtdeDolar)
        {
            double total = valorCotacao * qtdeDolar;
            return total + (total * 6 / 100);
        }
    }
}
