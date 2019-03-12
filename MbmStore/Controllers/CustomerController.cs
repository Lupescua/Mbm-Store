using MbmStore.Infrastructure;
using MbmStore.Models;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer bruce = new Customer(12, "Bruce", "Wayne", "Wayne Mansion", "1", "Gotham");
            bruce.AddPhone("123-789456");
            bruce.AddPhone("885-542265");
            bruce.Birthdate = new System.DateTime(1939, 5, 26);
            Customer gandhi = new Customer(13, "Mohandas Karamchand", "Gandhi", "Ghandi's home", "67", "Porbandar");
            gandhi.AddPhone("515-394851");
            gandhi.Birthdate = new System.DateTime(1969, 10, 2);
            Customer vlad = new Customer(14, "Vladimir ", "Putin", "Top of a Bear", "69", "Saint Petersburg");
            vlad.AddPhone("758-5642545");
            vlad.Birthdate = new System.DateTime(1952, 10, 7);
            // Adds each newly created customer to the ViewBag
            ViewBag.Bruce = bruce;
            ViewBag.Gandhi = gandhi;
            ViewBag.Vlad = vlad;

            // For show and tell, we also add the customers that are created in the Repository
            Repository repo = new Repository();
            ViewBag.Customers = repo.Customers;

            return View();
        }
    }
}