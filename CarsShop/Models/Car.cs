using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarsShop.Models
{
    public class Car : MainParametrsCar
    {
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string Mark { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string Series { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string BodyType { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string FuelType { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string Country { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string City { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string Transmission { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string Drive { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public override string Color { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int Distance { get; set; }
    }
}