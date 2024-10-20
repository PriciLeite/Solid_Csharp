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
    }

    public class Carro : Veiculo
    {
        public Carro(string numeroChassis) : base(numeroChassis)
        {
            System.Console.WriteLine($"Inicializando Carro: {numeroChassis}");
        }

    }


    static void Main(string[] args)
    {
        var carro = new Carro("E34910");
    }
}







