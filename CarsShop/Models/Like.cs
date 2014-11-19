using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsShop.Models
{
    public class Like
    {
        
        
        public string Author { get; set; }
        public Guid CarId { get; set; }
        public Guid Id { get; set; }

        public Like(Guid carId, string author)
        {
            this.CarId = carId;
            this.Author = author;
            this.Id = Guid.NewGuid();
        }

        public Like() { }
    }
}