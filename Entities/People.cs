using System;
using System.Runtime.InteropServices;

namespace Solid;


public class People
{
    // Encapsulate Members private:
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Gender { get; private set; }


    // Specific constructor:
    public People(string name, string gender, int age)
    {
        if (age >= 18)
        {
            System.Console.WriteLine($"Idade: {age}");
        }
        else
        {
            throw new InvalidOperationException("Idade inválida, menor que 18");
        }

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            throw new InvalidOperationException();

        this.Name = name;
        this.Gender = gender;
        this.Age = age;
    }


}



