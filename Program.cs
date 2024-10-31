using System.Globalization;
using System.Security.Cryptography.X509Certificates;


namespace Solid;
class program
{
    static void Main(string[] args)
    {
        Forma f = new Forma();
        Circulo c = f as Circulo; // Realizando a conversão de tipos de forma explícita (DownCasting)

        if (c != null)
        {
            c.Pintar();
        }
        else
        {
            System.Console.WriteLine($"Obejto Circulo {c} nulo!");
        }

    }
}







