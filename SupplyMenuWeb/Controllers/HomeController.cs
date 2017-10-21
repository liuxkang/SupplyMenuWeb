using System.Web.Mvc;
using SupplyMenuWeb.Models;

namespace SupplyMenuWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            SupplyDB db = new SupplyDB();
            return View("Index",db);
        }
    }
}