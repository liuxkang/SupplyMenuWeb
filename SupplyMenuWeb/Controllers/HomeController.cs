using System.Web.Mvc;
using SupplyMenuWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
namespace SupplyMenuWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            List<Supply> list_su = new SupplyDB().Supplies.ToList<Supply>();

            var a = list_su.Where("");
            return View("Index", a.ToList<Supply>());
        }
    }
}