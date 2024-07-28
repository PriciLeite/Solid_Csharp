using System;

namespace Solid
{
    class program
    {
        static void Main(string[] args)
        {
            //Generalist builder:
            People p1 = new People("John");
            p1.Gender = "Masculino";
            p1.Age = 17;

            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p1.Gender);
            System.Console.WriteLine(p1.Age);



        }
    }
}

