using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarsShop.Models
{
    public class MainParametrsCar
    {
       public string Mark { get; set; }
       public string Series { get; set; }
       public string BodyType { get; set; }
       public string FuelType { get; set; }
       public string Country { get; set; }
       public string City { get; set; }
       public string Transmission { get; set; }
       public string Drive { get; set; }
       public string Color { get; set; }

       [Display(Name = "Кондиционер")]
       public bool Conditioner { get; set; }


       [Display(Name = "Кожаный салон")]
       public bool LeatherSeats { get; set; }

       [Display(Name = "Подогрев сидений")]
       public bool HeatedSeats { get; set; }

       [Display(Name = "Парктроник")]
       public bool Parktronic { get; set; }

       [Display(Name = "Ксенон")]
       public bool Ksenon { get; set; }

       [Display(Name = "Громкая связь")]
       public bool Speakerphone { get; set; }

       [Display(Name = "Легкосплавленные диски")]
       public bool LegkosplavlennyeWheels { get; set; }

       [Display(Name = "Система контроля стабилизации")]
       public bool ESP { get; set; }
   
    }
}