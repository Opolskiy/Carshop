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
           // List<Car> list = new List<Car>();
            //Car car;
            var PropArray = typeof(Car).GetProperties();
            List<Car> list = Db.Cars.Where(s => (s.Mark == Data.Mark || Data.Mark == null)
                                               && (s.Series == Data.Series || Data.Series == null) 
                                               && (s.BodyType == Data.BodyType || Data.BodyType == null)
                                               && (s.Transmission == Data.Transmission || Data.Transmission == null)
                                               && (s.FuelType == Data.FuelType || Data.FuelType == null)
                                               && (s.Price < Data.Price_max && s.Price > Data.Price_min || Data.Price_min == 0 || Data.Price_max == 0)
                                               && (s.Distance < Data.Distance_max && s.Distance > Data.Distance_min || Data.Distance_max == 0 || Data.Distance_min == 0)
                                               && (s.Country == Data.Country || Data.Country == null)
                                               && (s.City == Data.City || Data.City == null)
                                               && (s.Color == Data.Color || Data.Color == null)
                                               && (s.Drive == Data.Drive || Data.Drive == null)
                                               && (s.Year < Data.Year_max && s.Year > Data.Year_min || Data.Year_min == 0 || Data.Year_max == 0)
                                               && (s.Conditioner == Data.Conditioner || Data.Conditioner == false)
                                               && (s.LeatherSeats == Data.LeatherSeats || Data.LeatherSeats == false)
                                               && (s.HeatedSeats == Data.HeatedSeats || Data.HeatedSeats == false)
                                               && (s.Parktronic == Data.Parktronic || Data.Parktronic == false)
                                               && (s.Ksenon == Data.Ksenon || Data.Ksenon == false)
                                               && (s.Speakerphone == Data.Speakerphone || Data.Speakerphone == false)
                                               && (s.LegkosplavlennyeWheels == Data.LegkosplavlennyeWheels || Data.LegkosplavlennyeWheels == false)
                                               && (s.ESP == Data.ESP || Data.ESP == false)).ToList();
            
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