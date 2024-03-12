using System;

namespace Solid
{
    class program
    {
        static void Main(string[] args)
        {
            //Generalist builder:
            Pessoa pessoa1 = new Pessoa();
            pessoa1.name = "José";
            pessoa1.age = 45;
            pessoa1.gender = "Masculino";
            pessoa1.Identification();


            //Specific builder:"
            Pessoa pessoa2 = new Pessoa("Maria", 23, "Feminino");
            pessoa2.Identification();





        }
    }
}

