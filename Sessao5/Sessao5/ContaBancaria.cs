using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao5 {
    internal class ContaBancaria {
        public int NumeroDaConta { get; private set; }
        public string _nome;
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaconta, string nome) {
            NumeroDaConta = numeroDaconta;
            _nome = nome;
        }

        public ContaBancaria(int numeroDaconta, string nome,  double depositoInicial) : this(numeroDaconta,nome){ // o this aproveita a estrutura do outro construtor
            Deposito(depositoInicial);
        }

        public string Nome{
            get{
                return _nome;
            }
            set {
                if (value != null && value.Length > 2)
                {
                    _nome = value;
                }
            }
        }
        
        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor;
            Saldo -= 5;
        }

        public override string ToString() {
            return "Conta: "+ NumeroDaConta +", Titular: "+_nome+", Saldo: "+Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
