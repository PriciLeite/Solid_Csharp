using System;

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
            if (value < 18)
            {
                System.Console.WriteLine("Idade menor do que 18!");
            }
            else
            {
                this.age = value;
            }
        }
        get { return age; }

    }

}



