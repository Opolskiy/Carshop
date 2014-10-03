using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsShop.Models;

namespace CarsShop.Controllers
{
    public class SearchController : Controller
    {
        [HttpPost]
        public ActionResult SearchResults(SearchObject data)
        {
            return RedirectToAction("SearchResult");
        }

        public ActionResult SearchResult()
        {

            return View();
        }
	}
}