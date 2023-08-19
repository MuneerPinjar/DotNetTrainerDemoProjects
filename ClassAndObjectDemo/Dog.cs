using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectDemo
{
    public class Dog
    {
        //instance variables
        string name;
        string breed;
        int age;
        string color;
        string description;


        //Constructor to initialize the class

        //Defualt construtor
        public Dog()
        {

        }

        // Parameterised constructor

        public Dog(string name, string breed, int age, string color, string description)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
            this.description = description;
        }

        // public methods
        public string GetName()
        {
            return name;
        }

        public string GetBreed()
        {
            return breed;
        }
        public string GetAge()
        {
            return age.ToString();
        }
        public string GetColor()
        {
            return color;
        }
        public string GetDescription()
        {
            return description;
        }

        public string GetDetailsInString()
        {
            return ("Hi my name is " + this.GetName() + " My Breed, age and color are :" + this.GetBreed() + ',' + this.GetAge() +',' +this.GetColor());
        }

        public string Bark()
        {
            return "This is " + this.GetName() + "'s Bark";
        }



    }
}
