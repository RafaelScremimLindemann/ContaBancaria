using Conta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Feito por Rafael Scremim Lindemann 11/10/2022
Sistema simples para inserção de dados em uma conta; Inclusão de valor de deposito;
Saque com desconto; utilizando POO acessando outra classe.*/

namespace Conta;

    class Conta
    {
        static void Main(string[] args)
    {
        Movimento m;
        
        Console.Write("Numero conta: ");
        int conta = int.Parse(Console.ReadLine());

        Console.Write("Nome do titular: ");
        string titular = Console.ReadLine();

        Console.Write("Havera deposito (s/n)?: ");
        char cond = char.Parse(Console.ReadLine()); 
        if (cond == 's')
        {
            Console.Write("Qual o valor do deposito: ");
            double depositoInicial = double.Parse(Console.ReadLine());
            m = new Movimento(conta, titular, depositoInicial);
        }else
        {
            m = new Movimento(conta,titular);
        }

        Console.WriteLine(m);

        Console.WriteLine();
        Console.Write("Entre com deposito: ");
        double valorDeposito = double.Parse(Console.ReadLine());
        m.Deposito(valorDeposito);
        Console.WriteLine(m);

        Console.WriteLine();
        Console.Write("Saque com 5 reais de desconto: ");
        double valorSaque = double.Parse(Console.ReadLine());
        m.Saque(valorSaque);
        Console.WriteLine("Seu saldo é de: "+ m);

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para sair...");
        Console.Read();
    }
}

