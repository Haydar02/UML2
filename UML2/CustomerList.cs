using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UML2
{
    class CustomerList
    {
        public Dictionary<int, Customer> customers;



        public CustomerList()
        {
            customers =new Dictionary<int, Customer>();
        }
        public void CreateCustomer(Customer customer) 
            
        {
            customers.Add(customer.Id, customer);

        }

        public Customer ReadCustomer(int id)
        {
            return customers[id];
        }

        public void UpdateCustomer(Customer customer) {
            Customer c = ReadCustomer(customer.Id);
            c.Name = customer.Name;
            c.TelefonNomber = customer.TelefonNomber;
        }
        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer.Id);

        }
        public void PrintCustomerinfo() 
        {
            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Value.Id}   ,  {c.Value.Name}  ,  {c.Value.TelefonNomber}");
            }
          
        }
        public Customer Search(string name) {
            return customers.FirstOrDefault(a => a.Value.Name.Contains(name)).Value;
        }


    }
}
