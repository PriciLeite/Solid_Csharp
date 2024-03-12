using System;

class Pessoa
{
    //field:
    public string name;
    public int age;
    public string gender;

    //Generalist builder:
    public Pessoa()
    {
    }

    // Specific builder:
    public Pessoa(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    public void Identification()
    {
        Console.WriteLine($"Hello, my name is {name}, my age is {age} years old and my gender is {gender}. Nice to meet you!");
    }



}
