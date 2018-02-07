using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise3c.Models;

namespace Exercise3c.DAL
{
    public class DummyCustomerRepository : ICustomerRepository
    {
        public DummyCustomerRepository()
        {
        }
        public void Dispose()
        {
        }

        public Customer GetCustomerByID(int ID)
        {
            return new Customer() { CustomerID = "Cust01", ContactName = "Fake Name", Country="Ireland" };
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>() { new Customer() { CustomerID = "Cust01", ContactName = "Fake Name", Country = "Ireland" } };
        }
    }
}