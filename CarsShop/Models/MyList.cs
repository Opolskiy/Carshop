using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsShop.Models
{
    public class MyList <T> : List<T>
        where T : class
    {
        public T a { get; set; }
        public MyList(T aVal)
        {
            a = aVal;
        }

        public MyList(IEnumerable<T> m) :base(m) {}

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public MyList()
        {
            a = default(T);
        }
        
    }
}