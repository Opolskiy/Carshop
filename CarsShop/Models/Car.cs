using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarsShop.Models
{
    public class Car : MainParametrsCar
    {
        [Required]
        [Display(Name = "Марка")]
        public override string Mark { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Модель")]
        public override string Series { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Тип кузова")]
        public override string BodyType { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Тип топлива")]
        public override string FuelType { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Страна")]
        public override string Country { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Город")]
        public override string City { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Трансмиссия")]
        public override string Transmission { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Привод")]
        public override string Drive { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Цвет")]
        public override string Color { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Стоимость")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Год выпуска")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Пробег")]
        public int Distance { get; set; }
    }
}