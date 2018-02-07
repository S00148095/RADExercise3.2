using Exercise3c.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise3c.DAL
{
    public interface ICustomerRepository:IDisposable
    {
        List<Customer> GetCustomers();
        Customer GetCustomerByID(int ID);
    }
}