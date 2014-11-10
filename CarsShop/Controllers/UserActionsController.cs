using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using CarsShop.Models;
using System.Threading;


namespace CarsShop.Controllers
{
    public class UserActionsController : Controller
    {
        private static Mutex mutex = new Mutex();

        public ActionResult Comments(Guid CarId)//
        {
            return View(CarId);
        }

        public ActionResult EditView(Guid CarId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            var car = Db.Cars.FirstOrDefault(c => c.CarId == CarId);
            // Db.SaveChanges();
            return View(car);
        }

        public ActionResult AddEditons(Car Model, Guid? id)
        {
           
                ApplicationDbContext db = new ApplicationDbContext();
                var arr = typeof(Car).GetProperties();    
                var changedCar = db.Cars.Where(c => c.CarId == id).ToArray()[0];
               
                
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (i != 15 && i != 12 && i != 13)
                    {
                        arr[i].SetValue(changedCar, arr[i].GetValue(Model));
                    }
                }
                db.SaveChanges();
            return RedirectToAction("MyDeclarations");
        }

        public ActionResult CompareDeclarations()
        {
            return View();
        }

        [Authorize]
        public ActionResult MyDeclarations()
        {

            ApplicationDbContext Db = new ApplicationDbContext();
            List<Car> list = Db.Cars.Where(s => s.Author == User.Identity.Name).ToList();
            list.Sort(delegate(Car x, Car y)
            {
                if (x.DateAdded > y.DateAdded) return -1;
                if (x.DateAdded < y.DateAdded) return 1;
                else return 0;
            }
            );
            return View(list);
        }


        public ActionResult DeleteCar(Guid CarId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            var car = Db.Cars.FirstOrDefault(c => c.CarId == CarId);
            Db.Cars.Remove(car);
            Db.SaveChanges();
            return RedirectToAction("MyDeclarations");
        }
    }
}