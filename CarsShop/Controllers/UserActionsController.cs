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

        public ActionResult DeleteComment(Guid CommentId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            
            var com = Db.Comments.FirstOrDefault(c => c.CommentId == CommentId);
            var car = Db.Cars.FirstOrDefault(m => m.CarId == com.CarId);
            if ( User.Identity.Name == com.Author )
            {
                Db.Comments.Remove(com);
                Db.SaveChanges();
            }
            else { return Content("error"); }
            return RedirectToAction("Comments", "UserActions", car);
        }

        public ActionResult NewComment(Comment comment)
        {
            comment.Author = User.Identity.Name;
            comment.Date = DateTime.Now;
            comment.CommentId = Guid.NewGuid();
            ApplicationDbContext db = new ApplicationDbContext();
            db.Comments.Add(comment);
            db.SaveChanges();
            Car c = db.Cars.FirstOrDefault(s => s.CarId == comment.CarId);
            return RedirectToAction("Comments", "UserActions", c);
        }

        public ActionResult _CommentPartial(Guid CarId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List <Comment> commentList = new List<Comment>();
            commentList = db.Comments.Where(c => c.CarId == CarId).ToList();
            commentList.Sort(delegate(Comment x, Comment y) 
            { 
                if(x.Date < y.Date) return -1;
                if ( x.Date > y.Date ) return 1;
                else return 0;
            });
            ViewBag.ListComments = commentList;
            Comment com = new Comment();
            com.CarId = CarId;
            return PartialView(com);
        }

        public ActionResult Viewsplusplus(Guid CarId)
        {
            var prop = typeof(Car).GetProperty("CountViews");
            ApplicationDbContext Db = new ApplicationDbContext();
            var car = Db.Cars.FirstOrDefault(c => c.CarId == CarId);
            prop.SetValue(car, car.CountViews + 1);
            Db.SaveChanges();
            return RedirectToAction("Comments", new { CarId = CarId });
        }

        public ActionResult Comments(Guid CarId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            var car = Db.Cars.FirstOrDefault(c => c.CarId == CarId);
            return View(car);
        }

        public ActionResult EditView(Guid CarId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            var car = Db.Cars.FirstOrDefault(c => c.CarId == CarId);
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