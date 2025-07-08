using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretendDatabase
{
    public class CityDatabase
    {
        // Pretend this is a link to a database
        List<City> cities = new List<City>
        {
            new City { Name = "London", Country = "UK", Population = 8982000 },
            new City { Name = "Paris", Country = "France", Population = 2148000 },
            new City { Name = "New York", Country = "USA", Population = 8419000 }
        };

        public void getAll()
        {
            string val = "get all!";
            foreach (City city in cities)
            {
                Console.WriteLine(city.ToString());
            }
        }

        // Create
        public void create(string name, string country, int population)
        {
            cities.Add(new City { Name = name, Country = country, Population = population });
            Console.WriteLine($"Added {name} ");
        }

        // Read
        public void read(string name)
        {
            City foundcity = cities.Find(p => p.Name == name);
            if (foundcity != null)
            {
                Console.WriteLine($"\nSearched For : {name} | Found : {foundcity.ToString()}");
            }
            else
            {
                Console.WriteLine($"\nSearched For : {name} | Found : None");
            }
        }

        // Update
        public void update(string search, string name, string country, int population)
        {
            City foundcity = cities.Find(p => p.Name == search);
            if (foundcity != null)
            {
                Console.WriteLine($"Updating : {foundcity.Name}");
                foundcity.Name = name;
                foundcity.Country = country;
                foundcity.Population = population;
                Console.WriteLine($"New Values : {foundcity.ToString()}");
            }
            else
            {
                Console.WriteLine($"Updating For : {search} | Found : None");
            }
        }

        // Delete
        public void delete(string name)
        {
            City foundcity = cities.Find(p => p.Name == name);
            if (foundcity != null)
            {
                Console.WriteLine($"Deleting : {foundcity.Name}");
                cities.RemoveAll(c => c.Name == name);
            }
            else
            {
                Console.WriteLine($"\nSearched For : {name} | Found : None");
            }
        }
    }

    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Country} - Population: {Population}";
        }
    }
}