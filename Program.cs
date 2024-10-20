using System.Globalization;


namespace Solid;

class program
{
    public class Veiculo
    {
        private string numeroChasis { get; set; }

        public Veiculo(string numeroChassis)
        {
            this.numeroChasis = numeroChassis;
            System.Console.WriteLine($"Inicializando Veiculo: {numeroChasis}");
        }

        public virtual void MetodoTeste()
        {
            System.Console.WriteLine("Teste de retorno para o método da classe Veiculo.");
        }
    }


    public class Carro : Veiculo
    {
        public Carro(string numeroChassis) : base(numeroChassis)
        {
            System.Console.WriteLine($"Inicializando Carro: {numeroChassis}");
        }

        public override void MetodoTeste()
        {
            base.MetodoTeste();
            System.Console.WriteLine("Teste de retorno para o método herdado da classe Veiculo.");
        }

    }

    static void Main(string[] args)
    {
        var carro = new Carro("E34910");
        carro.MetodoTeste();
    }
}







