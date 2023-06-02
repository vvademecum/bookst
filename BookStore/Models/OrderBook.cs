using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Models
{
    public class OrderBook
    {
        public int Id { get; set; }

        public Book Book { get; set; }

        public int Quantity { get; set; }

    }
}
