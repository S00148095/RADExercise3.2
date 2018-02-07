using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise3c.Models;

namespace Exercise3c.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private SampleDBEntities context;

        public CustomerRepository(SampleDBEntities context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Customer GetCustomerByID(int ID)
        {
            return context.Customers.Find(ID);
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
    }
}