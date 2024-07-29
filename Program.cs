using System;
using System.Security.Cryptography.X509Certificates;

namespace Solid
{
    class program
    {
        // Aplicando: Métodos com Argumentos Nomeados.
        static void Enviar(string destino, string titulo, string assunto)
        {
            System.Console.WriteLine($"\n{destino} - {titulo} - {assunto}\n");
        }

        static void Main(string[] args)
        {
            Enviar(titulo: "Contrato", assunto: "Responder ao receber este e-mail.", destino: "prici_leite@gmail.com");
        }
    }
}

