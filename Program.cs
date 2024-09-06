using System.Globalization;


namespace Solid;

class program
{

    class Conta
    {
        public Conta()
        {
            System.Console.WriteLine("Testando se a classe derivada irá excutar primeiro o construtor da classe base");
        }

        public int Numero { get; set; }
        public double Saldo { get; set; }



        protected void GetSaldo()
        {
            System.Console.WriteLine($"Seu saldo atual R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }



        internal void Saque()
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
                throw new Exception($"\nSeu saldo de R${Saldo.ToString("F2", CultureInfo.InvariantCulture)} é insuficiente!\n");
            }

        }

    }

    class ContaPoupanca : Conta
    {
        public int JurosMensais { get; set; }

        protected new void GetSaldo()
        {
            System.Console.WriteLine("Método (Saldo) da classe base foi ocultado por uso da palavra 'new'");
        }

        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Numero = 001;
            cp.Saldo = 1000.00;
            cp.GetSaldo();
            cp.Saque();
        }
    }


}




