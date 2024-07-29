using System;
using System.Security.Cryptography.X509Certificates;

namespace Solid
{
    class program
    {
        static void Main(string[] args)
        {
            // Chamando o método sem instânciar um objeto:            
            System.Console.WriteLine($"Somar: {Calculadora.Somar(2, 5)}");
            System.Console.WriteLine($"Subtrair: {Calculadora.Subtracao(5, 2)}");
        }
    }
}

