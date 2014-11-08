using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsShop.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public Guid PicId { get; set; }
        public byte[] Image { get; set;}
    }
}