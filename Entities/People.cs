using System;
using System.Runtime.InteropServices;

namespace Solid;


public class People
{
    private string name;
    private int age;
    private string gender;

    // Encapsulate Members private:
    public string Name { get => name; private set => name = value; }
    public int Age { get => age; private set => age = value; }
    public string Gender { get => gender; private set => gender = value; }


    // Specific constructor:
    public People(string name, string gender, int age)
    {
        DomainExptionValidation.When(age < 18, "Idade inválida, menor que 18 anos.");
        DomainExptionValidation.When(string.IsNullOrEmpty(name), "Obrigatório digitar um nome.");
        DomainExptionValidation.When(string.IsNullOrEmpty(gender), "Obrigatório digitar um gênero de usuário.");

        this.Name = name;
        this.Gender = gender;
        this.Age = age;
    }


}



