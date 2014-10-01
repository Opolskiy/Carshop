using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsShop.Models
{
    public class SearchObject : MainParametrsCar
    {
        public int Price_min { get; set; }
        public int Price_max { get; set; }
        public int Year_min { get; set; }
        public int Year_max { get; set; }
        public int Distance_min { get; set; }
        public int Distance_max { get; set; }
    }
}