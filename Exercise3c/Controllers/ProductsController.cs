using Exercise3c.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise3c.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository repository;

        public ProductsController(ProductRepository repo)
        {
            repository = repo;
        }
        // GET: Products
        public ActionResult Index()
        {
            return View(repository.GetProducts());
        }

    }
}
