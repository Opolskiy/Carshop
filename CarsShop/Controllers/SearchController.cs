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
        public ActionResult SearchResults(SearchObject Data)
        {
            
            return RedirectToAction("SearchResult");
        }

        public ActionResult SearchResult(SearchObject Data)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            IList<Car> list = Db.Cars.Where(s => s.Mark == Data.Mark || Data.Mark == null).ToList();
            return View(list);
        }
	}
}