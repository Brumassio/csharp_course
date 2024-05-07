using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao6 {
    internal class RegistroPensionato {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString() {
            return Quarto.ToString()+": "+Nome+", "+ Email;
        }

    }
}
