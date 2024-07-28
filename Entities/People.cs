using System;
using System.Runtime.InteropServices;

namespace Solid;


public class People
{
    // Encapsulate Members private:
    private string name;
    private int age;
    private string gender;

    // Access member public:
    public string Name { get; }

    // Specific constructor:
    public People(string name)
    {
        DomainExptionValidation.When(string.IsNullOrEmpty(name), "O nome deve ser informado.");
        this.Name = name;
    }

    // Update set gender:
    public string Gender
    {
        set
        {
            gender = value;
        }
        // Access member public:
        get { return gender; }
    }

    // Update set age / condition:
    public int Age
    {
        set
        {
            if (value > 18)
            {
                this.age = value;
            }
            else
            {
                DomainExptionValidation.When(value < 18, "Idade menor do que 18!");
            }
        }
        get { return age; }

    }

}



