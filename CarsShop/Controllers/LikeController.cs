using System;
using System.Linq;
using System.Web.Mvc;
using CarsShop.Models;
using System.Collections.Generic;

namespace CarsShop.Controllers
{
    public class LikeController : Controller
    {
        // GET: Like
        public ActionResult NewLike(Guid CarId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
          
            var lk = db.Likes.FirstOrDefault(c => c.CarId == CarId  && (c.Author == User.Identity.Name)) ;
                if(lk == null)
                {
                    Like l = new Like(CarId, User.Identity.Name);
                    db.Likes.Add(l);
                    db.SaveChanges();
                }
                else
                {
                    db.Likes.Remove(lk);
                    db.SaveChanges();
                }
                List<Like> data = db.Likes.Where(s => s.CarId == CarId).ToList();
            return Content(data.Count.ToString());
        }
    }
}