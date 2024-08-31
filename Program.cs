using System;
using Solid.Utils;


namespace Solid
{
    class program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "maria";

            // método de extensão
            texto1 = texto1.CaixaAltaPrimeiraLetra();
            texto2 = texto2.CaixaAltaPrimeiraLetra();

            System.Console.WriteLine(texto1);
            System.Console.WriteLine(texto2);
        }
    }
}

