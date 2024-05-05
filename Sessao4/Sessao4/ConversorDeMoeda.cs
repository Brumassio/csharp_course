using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao4 {
    internal static class ConversorDeMoeda {
        public static double ConverterMoeda(double cotacaoDollar, double qtdDollar) {
            double aux = cotacaoDollar * qtdDollar;
            return aux + (aux * 6/100);
        }
    }
}
