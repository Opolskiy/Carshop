using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsShop.Models
{
    public class SearchObject : MainParametrsCar
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
        public int Price_min { get; set; }
        public int Price_max { get; set; }
        public int Year_min { get; set; }
        public int Year_max { get; set; }
        public int Distance_min { get; set; }
        public int Distance_max { get; set; }
    }
}