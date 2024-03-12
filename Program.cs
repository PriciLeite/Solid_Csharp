using System;

namespace Solid
{
    class program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.name = "José";
            pessoa1.age = 20;
            pessoa1.gender = "Masculino";

            pessoa1.Identification();

        }
    }
}

