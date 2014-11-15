using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsShop.Models
{
    public class Comment
    {
        public Guid CarId { get; set;}
        public Guid CommentId { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Data { get; set; }
    }
}