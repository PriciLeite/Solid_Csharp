using System;
using System.Globalization;
using System.Security.Claims;
using Solid.Utils;


namespace Solid;

class program
{
    static void Main(string[] args)
    {
        ContaPoupanca cp = new ContaPoupanca();
        cp.Numero = 001;
        cp.Saldo = 1000.00;
        cp.GetSaldo();
        cp.Saque();
    }

    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public void GetSaldo()
        {
            System.Console.WriteLine($"Seu saldo atual R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Saque()
        {
            System.Console.Write("Digite valor para saque: ");
            double valor = double.Parse(Console.ReadLine());

            if (Saldo > 0 && Saldo > valor)
            {
                Saldo = Saldo - valor;
                System.Console.WriteLine($"Seu saldo atual é R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}\n");
            }
            else
            {
                throw new Exception($"Saldo {Saldo} insuficiente! ");
            }

        }

    }

    class ContaPoupanca : Conta
    {
        public int JurosMensais { get; set; }
    }


}




