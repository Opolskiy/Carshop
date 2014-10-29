﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using CarsShop.Models;


namespace CarsShop.Controllers
{
    public class UserActionsController : Controller
    {
       
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
        

        public ActionResult DeleteCar (Guid CarId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            var car = Db.Cars.FirstOrDefault(c => c.CarId == CarId);
            Db.Cars.Remove(car);
            Db.SaveChanges();
            return RedirectToAction("MyDeclarations");
        }
	}
}