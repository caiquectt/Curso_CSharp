using System.Globalization;

namespace Exercicio_Fixação__Construtores_
{
    public class ContaBancaria
    {
        public int Conta {get; private set;}
        public string Nome {get; set;}
        public double Saldo {get; private set;}

        public ContaBancaria(int conta, string nome){
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria(int conta, string nome, double depositoInicial) : this(conta, nome){
            Deposito(depositoInicial);
        }

        public override string ToString()
        {
            return "Conta "
            + Conta
            + ", Titular: "
            + Nome
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposito(double quantia){
            Saldo += quantia;
        }

        public void Saque(double quantia){
            Saldo -= quantia + 5;
        }
    }
}