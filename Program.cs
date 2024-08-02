using System;
using System.Security.Cryptography.X509Certificates;

namespace Solid
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Produto produto = new Produto("TVz", 1999.99m); // Isso funcionará
                Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");

                // Isso lançará uma exceção
                Produto produtoInvalido = new Produto("AB", 100.00m);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar o produto: {ex.Message}");
            }
        }
    }
}

