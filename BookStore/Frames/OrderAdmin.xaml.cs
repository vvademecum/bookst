using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookStore.Models;
using BookStore.Utils;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Frames
{
    /// <summary>
    /// Логика взаимодействия для OrderAdmin.xaml
    /// </summary>
    public partial class OrderAdmin : Page
    {

        public OrderAdmin(Order order)
        {
            InitializeComponent();

            List<OrderBook> orderBooks = order.orderBooks;
            UpdateItems(orderBooks);
        }

        private void UpdateItems(List<OrderBook> orderBooks)
        {
            //List<Order> orders = BookStoreDbContext.db.Orders.Include(o => o.orderBooks).Include(o => o.orderBooks).ToList();
            //List<OrderBook> orderBooks1 = BookStoreDbContext.db.OrderBooks.Include(ob => ob.Book).Where(ob => ob.Equals(orderBooks));


            OrdersLV.ItemsSource = null;
            OrdersLV.ItemsSource = orderBooks;
        }



    }
}
