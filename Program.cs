using System;
using System.Collections.Generic;

namespace GenericListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 3000,
                Type = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 106,
                Name = "Ben",
                Salary = 9000,
                Type = "RetailCustomer"
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3600,
                Type = "RetailCustomer"
            };

            Customer customer4 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3600,
                Type = "CorporateCustomer"
            };

            Customer customer5 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3600,
                Type = "CorporateCustomer"
            };


            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            //customers.Insert(0, customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            customers.AddRange(listCorporateCustomers);

            customers.InsertRange(3, listCorporateCustomers);

            customers.Remove(customer1);

            foreach(Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);

            }

        }

    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }

    
}

