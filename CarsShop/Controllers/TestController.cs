using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsShop.Models;

namespace CarsShop.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index(Car test)
        {
            
            return View();
        }
	}
}