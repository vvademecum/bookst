using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }
        public Byte[] Image { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public int QuantityInStock { get; set; }
    }
}
