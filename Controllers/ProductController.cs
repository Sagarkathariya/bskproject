using bskproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace bskproject.Controllers
{
    public class ProductController : Controller
    {
        //private readonly MyAppDbContext _context;

        // these for accessing data from multiple table
        /*public ProductController(MyAppDbContext DbContext)
        {
            _context = DbContext;
        }*/
        public IActionResult ProductList
        {
            get
            {
                try
                {
                    //This for accessing data from single table
                    //var products = _context.Products.ToList();
                    return View();
                }
                catch (Exception)
                {
                    return View();
                }

            }
        }
    }
}
