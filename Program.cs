using System.Globalization;
using System.Security.Cryptography.X509Certificates;


namespace Solid;
class program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo();
        Forma f = circulo; // UpCasting -> Implícita

        Circulo c = (Circulo)f;

        System.Console.WriteLine(c == f);
        System.Console.WriteLine(c == circulo);

    }
}







