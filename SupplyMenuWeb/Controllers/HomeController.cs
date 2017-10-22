﻿using System.Web.Mvc;
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

            var result = from a in list_su
                         where a.Classify.Trim() == "0101"
                         where a.SupplyName.Contains("笔")
                         select a;
            return View("Index", result.ToList<Supply>());
        }
    }
}