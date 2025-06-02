using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // The goal is to build something that can sort people based on age

    // Create generic in that compares 2 inputs, x and y
    public delegate int Comparison<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            //1. go through all people except for last one 
            //2. "i" is the second to last one
            //2. last one is "j"
            //3. if i is greater than j then swap the postions of each values
            // THis is an implementation of a bubblesort
            for (int i = 0; i < people.Length-1; i++)
            {
                for(int j = i+1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }

    public class Sorting
    {
        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
        public void Run()
        {
            // Create array of people
            Person[] people =
            {
                new Person{Name="Lisa", Age=10},
                new Person{Name="Homer", Age=45},
                new Person{Name="Bart", Age=12},
                new Person{Name="Marge", Age=42},
                new Person{Name="Maggie", Age=2}
            };

            Console.WriteLine("UNSORTED ----------------------");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name : {person.Name} | Age : {person.Age}");
            }

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);
            Console.WriteLine("SORTED ----------------------");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name : {person.Name} | Age : {person.Age}");
            }
        }
    }
}
