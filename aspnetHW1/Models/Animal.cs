using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetHW1.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public Animal(int iD, string name, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public List<Animal> GetAnimals()
        {
            return new List<Animal>
            {
                new Animal(10, "Cat", 2),
                new Animal(11, "Snake", 1),
                new Animal(12, "Dog", 3),
                new Animal(13, "Cow", 5),
                new Animal(14, "Rabbit", 2)
            };
        }


    }
}
