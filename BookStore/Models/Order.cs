using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;


namespace BookStore.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        public DateTime? dateTime { get; set; }

        public double? amountPrice { get; set; }

        public List<OrderBook> orderBooks { get; set; }
    }
}
