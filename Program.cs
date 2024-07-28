using System;

namespace Solid
{
    class program
    {
        static void Main(string[] args)
        {
            //Generalist builder:
            People p1 = new People("John", "masculino", 18);

            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p1.Gender);




        }
    }
}

