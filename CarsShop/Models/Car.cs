using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarsShop.Models
{
    public class Car
    {
       public string Mark { get; set; }
       public string Series { get; set; }
       public string Model { get; set; }
       public string Country { get; set; }
       public string City { get; set; }

       [Display(Name = "Запомнить меня")]
       public bool RememberMe { get; set; }
       
   
    }
}