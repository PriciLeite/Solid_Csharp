using System;

namespace Solid
{

    public class People
    {
        //
        private string name;
        private int age;
        private string gender;


        //builder enable set:
        public People(string name)
        {
            this.Name = name;
        }
        public string Name { get; }


        public string Gender
        {
            set
            {
                gender = value;
                System.Console.WriteLine(gender);
            }
        }

        //builder enable set condition:
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


}
