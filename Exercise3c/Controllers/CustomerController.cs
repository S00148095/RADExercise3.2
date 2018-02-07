using Exercise3c.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise3c.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository repository;

        public CustomerController(ICustomerRepository repo)
        {
            repository = repo;
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View(repository.GetCustomers());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(repository.GetCustomerByID(id));
        }
    }
}
