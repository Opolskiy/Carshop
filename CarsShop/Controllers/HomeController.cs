﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Drawing.Imaging;
using System.Drawing;
using CarsShop.Models;
using System.IO;
using System.Threading;

namespace CarsShop.Controllers
{
    public class HomeController : Controller
    {
        private static Mutex mutex = new Mutex();

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult NewDeclaration()
        {
            
            return View();
        }
        
        [HttpPost]
        public ActionResult AddNewDeclaration(Car C, HttpPostedFileBase fileUpload, Picture pic)
        {
            mutex.WaitOne();
            ApplicationDbContext db = new ApplicationDbContext();
            if (C != null)
            {
                
                string NameUser = User.Identity.Name;

                C.Author = NameUser;
                C.DateAdded = DateTime.Now;
                C.CarId = Guid.NewGuid();
                db.Cars.Add(C);
            }

            if (fileUpload != null)
            {

                using (var img = new Bitmap(fileUpload.InputStream))
                {
                    CreateFile(HttpRuntime.AppDomainAppPath + "/Photo/" + pic.Id + ".jpg", img);
                }
               
                pic.PicId = C.CarId;
                db.Pictures.Add(pic);
                
            }

            db.SaveChanges();

            AddEvent addEvent = new AddEvent();
            addEvent.AddCar += C.WriteDeclaration;
            addEvent.onAddEvent(User.Identity.Name);
            mutex.ReleaseMutex();
            return RedirectToAction("Index");
        }

        public static void CreateFile (string path, Bitmap img)
        {
            using(var f = System.IO.File.OpenWrite(path))
            {
                img.Save(f, ImageFormat.Jpeg);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        
    }
}