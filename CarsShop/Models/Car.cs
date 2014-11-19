using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Web;

namespace CarsShop.Models
{
    public delegate void Dgate (Object sender, string e);

    public class AddEvent
    {
        public event Dgate AddCar;
        public void onAddEvent(string e)
        {
            if (AddCar != null)
                AddCar(this, e);
        }
    }

    public class Car : MainParametrsCar
    {
        
        [Required]
        [Display(Name = "Марка")]
        public string Mark { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Модель")]
        public string Series { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Тип кузова")]
        public string BodyType { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Тип топлива")]
        public string FuelType { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Страна")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Трансмиссия")]
        public string Transmission { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Привод")]
        public string Drive { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Цвет")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Стоимость")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Год выпуска")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Пробег")]
        public int Distance { get; set; }

        public DateTime DateAdded { get; set; }
        public string Author { get; set; }
        public int CountViews { get; set; }
        public Guid CarId { get; set; }


        public Car( string Author, string Mark, string Series, string BodyType,
                    string FuelType, string Country, string City, 
                    string Transmission, string Drive, string Color,
                    int Price, int Year, int Distance)
        {
            this.Author = Author;
            this.Mark = Mark;
            this.Series = Series;
            this.BodyType = BodyType;
            this.FuelType = FuelType;
            this.Country = Country;
            this.City = City;
            this.Drive = Drive;
            this.Color = Color;
            this.Price = Price;
            this.Year = Year;
            this.Distance = Distance;
        }

        public Car() { }

        private static object sync = new object();

        public void WriteDeclaration(Object sender, String e)
        {
            lock (sync)
            {
                var file = new StreamWriter(HttpRuntime.AppDomainAppPath + "/Adds/" + e + ".txt", true);
                file.WriteLine("{0:F}-{1}-{2}", DateTime.Now, Mark, Year);
                file.Close();
            }
        }

        //public static void ReloadDeclaration(Car c)
        //{
        //    lock (sync)
        //    {
        //        ApplicationDbContext db = new ApplicationDbContext();
        //        c.CarId = Guid.NewGuid();
        //        db.Cars.Add(c);
        //        db.SaveChanges();
        //    }
        //}

    }   
}