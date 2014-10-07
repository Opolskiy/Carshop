using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

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
            return View();
        }
	}
}