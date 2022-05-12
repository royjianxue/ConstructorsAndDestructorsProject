using System;

namespace ConstructorsAndDestructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("First name: ");
                string input = Console.ReadLine();
                people[i] = new Person(input);
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; } 
        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Hello! My name is {Name}";
        }

        ~Person() // this will destroy the instance
        {
            Name = string.Empty;
        }

    }



}
