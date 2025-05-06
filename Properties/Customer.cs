using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Customer
    {
        public static int NumberOfCustomers = 0;
        public static int nextId = 0;
        private readonly int _id;
        private string _password;

        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        public Customer()
        {
            _id = nextId++;
            Name = "Default Name";
            Address = "Default Address";
            Contact = "Default Contact";
            Password = "Default Password";
            NumberOfCustomers++;
        }

        public void showDetails()
        {
            Console.WriteLine($"id : {_id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Address : {Address}");
            Console.WriteLine($"Contact : {Contact}");
        }

        public static void DisplayNumberOfCars()
        {
            Console.WriteLine($"Total customers: {NumberOfCustomers}");
        }

        public void getPasswrod()
        {
            Console.WriteLine($"password {Password}");
        }
    }
}
