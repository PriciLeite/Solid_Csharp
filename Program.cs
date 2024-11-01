using System.Globalization;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace Solid;
class program
{
    // Crie uma classe para  calcular 2 inteiros ou reais usando o conceito de SOBRECARGA de métodos. 
    // Se nenhum valor for informado, retorne a frase: "Nenhum valor fpo informado".
    public class Calcular
    {
        public string Somar()
        {
            return "Nenhum valor fornecido";
        }

        public int Somar(int x, int y)
        {
            return x + y;
        }

        public float Somar(float x, float y)
        {
            return x + y;
        }

        public float Somar(float x, int y)
        {
            return x + y;
        }
    }

    //Crie uma classe para calcular a soma de 4 inteiros usando o conceito de parâmetros opcionais. 
    class Calculadora
    {
        public static int Somar(int x, int z = 0, int w = 0) // 3 parâmetros opcionais com valores padrão igual a zero.
        {
            return x + z + w;
        }
    }



    static void Main(string[] args)
    {
        var a = Calculadora.Somar(2);
        System.Console.WriteLine($"a: {a}");
        var b = Calculadora.Somar(2, 2);
        System.Console.WriteLine($"b (x + z): {b}");
    }


}







