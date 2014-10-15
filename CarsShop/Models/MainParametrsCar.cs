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
       

       [Display(Name = "Кондиционер")]
       public virtual bool Conditioner { get; set; }

       [Display(Name = "Кожаный салон")]
       public virtual bool LeatherSeats { get; set; }

       [Display(Name = "Подогрев сидений")]
       public virtual bool HeatedSeats { get; set; }

       [Display(Name = "Парктроник")]
       public virtual bool Parktronic { get; set; }

       [Display(Name = "Ксенон")]
       public virtual bool Ksenon { get; set; }

       [Display(Name = "Громкая связь")]
       public virtual bool Speakerphone { get; set; }

       [Display(Name = "Легкосплавленные диски")]
       public virtual bool LegkosplavlennyeWheels { get; set; }

       [Display(Name = "Система контроля стабилизации")]
       public virtual bool ESP { get; set; }
   
    }
}