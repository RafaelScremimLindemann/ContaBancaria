using System.Globalization;

namespace Conta
{
    class Movimento
    {
        public int Conta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; set; }

//Construtor Movimento com dois argumentos.
        public Movimento(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }
//Construtor Movimento com tres argumentos.
        public Movimento(int conta, string titular, double valorDeposito) : this(conta, titular)
        {
            Deposito(valorDeposito);
        }
        

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }
        
        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque + 5;
        }

        public override string ToString()
        {
            return "Conta: " + Conta
                   + ", Titular: " + Titular
                   + ", Saldo: " + Saldo.ToString(CultureInfo.InvariantCulture);

        }
        }
        }


