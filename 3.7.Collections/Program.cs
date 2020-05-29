using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List");
            List<string> names = new List<string>();
            // Add the value to the end of the list
            names.Add("Joe");
            names.Add("Anna");
            names.Add("Jane");
            // Insert the value at the index specified and push the values in the right
            names.Insert(1, "Lucy");
            // Atribute a new value to the index especified
            names[0] = "Aiofe";
            // Delete the value in the index and reorganize the list
            names.RemoveAt(2);

            names.ForEach(name => Console.WriteLine(name));

            Console.WriteLine("Using custom types");
            IList<Company> companies = new List<Company>
            {
                new Company{ Name = "Microsoft" },
                new Company{ Name = "Apple" },
                new Company{ Name = "Canonical" }
            };

            foreach (var cp in companies)
            {
                Console.WriteLine(cp.Name);
            }
            Console.WriteLine();

            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
            Customer jane = new Customer { ID = 0, Name = "Jane" };
            Customer joe = new Customer { ID = 1, Name = "Joe" };
            customers.Add(jane.ID, jane);
            customers[joe.ID] = joe;

            foreach(var key in customers.Keys)
            {
                Console.WriteLine(customers[key].Name);
            }

            Console.ReadKey();
        }
    }

    class Company
    {
        public string Name { get; set; }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
