using System;
using System.Security.Cryptography.X509Certificates;

namespace Solid
{
    class program
    {
        static public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        static public double Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Recebendo um Array de parâmetros.
        static public int Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach (var num in numeros)
                resultado += num;
            return resultado;
        }


        static void Main(string[] args)
        {
            var resultado1 = Somar(100, 200);
            var resultado2 = Somar(100, 200, 100);
            var resultado3 = Somar(new int[] { 1, 2, 3 });
            //Simplificada.
            var resultado4 = Somar(1, 2, 3);

            System.Console.WriteLine(resultado1);
            System.Console.WriteLine(resultado2);
            System.Console.WriteLine(resultado3);
            System.Console.WriteLine(resultado4);



        }
    }
}

