using System.Globalization;
using System.Security.Cryptography.X509Certificates;


namespace Solid;
class program
{
    static void Main(string[] args)
    {
        Circulo c = new Circulo();
        Forma f = c; // Realizando UpCasting - Implicito.

        if (f is Circulo) // Verificando se a conversão é possível
        {
            ((Circulo)f).Pintar();
        }
        else
        {
            System.Console.WriteLine("A conversão não é possível!");
        }

    }
}







