using System;
using System.Security.Cryptography.X509Certificates;

namespace Solid
{
    class program
    {
        // Aplicando: Métodos com parâmetros opcioanais.
        static public int Somar(int num1, int num2 = 20, int num3 = 30, int num4 = 40)
        {
            return num1 + num2 + num3 + num4;
        }

        static void Main(string[] args)
        {
            var resultado1 = Somar(100);
            var resultado2 = Somar(100, 100);
            var resultado3 = Somar(100, 100, 100);
            var resultado4 = Somar(100, 100, 100, 100);

            System.Console.WriteLine(resultado1);
            System.Console.WriteLine(resultado2);
            System.Console.WriteLine(resultado3);
            System.Console.WriteLine(resultado4);
        }
    }
}

