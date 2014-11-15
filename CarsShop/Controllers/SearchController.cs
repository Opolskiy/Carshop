using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsShop.Models;
using System.Web.Script.Serialization;

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
            List<Car> list = Db.Cars.Where(s => (s.Mark == Data.Mark || Data.Mark == null) 
                                              && (s.Country == Data.Country || Data.Country == null)).ToList();
             List<Picture> pics= Db.Pictures.ToList();
             CarDataList result = new CarDataList(list,pics);
            return View(result);
        }

        public ActionResult Compare(string cars)
        {
            using (ApplicationDbContext Db = new ApplicationDbContext())
            {
                var serializer = new JavaScriptSerializer();
                List<Guid> selectedCarList = serializer.Deserialize<List<Guid>>(cars);
                List<Car> list = Db.Cars.Where(s => selectedCarList.Contains(s.CarId)).ToList();
                return View(list);
            }
        }


	}
}