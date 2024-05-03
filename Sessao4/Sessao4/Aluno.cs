using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao4 {
    internal class Aluno {
        public string? Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public void aprovacao() {
            double NotaFinal = Nota1+Nota2+Nota3;
            if (NotaFinal >= 60) {
                Console.WriteLine($"NOTAFINAL: {NotaFinal.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine($"NOTAFINAL: {NotaFinal.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine($"REPROVADO\n Faltaram {(-1*(NotaFinal-60)).ToString("F2",CultureInfo.InvariantCulture)} pontos");
            }
        }
        public override string ToString() {
            return base.ToString();
        }

    }
}
