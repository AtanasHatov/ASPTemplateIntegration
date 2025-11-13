using System.Diagnostics;
using ASPTemplateIntegration.Data;
using ASPTemplateIntegration.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPTemplateIntegration.Controllers
{
    public class HomeController(
        ApplicationDbContext context)
        : Controller
    {
        public IActionResult Index()
        {
            var products = context.Products.ToArray();
            var customers = context.Customer.ToArray();
            return View((products, customers));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
