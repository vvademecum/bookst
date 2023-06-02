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
using BookStore.Utils;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Frames
{
    /// <summary>
    /// Логика взаимодействия для MainAdmin.xaml
    /// </summary>
    public partial class MainAdmin : Page
    {
        public MainAdmin()
        {
            InitializeComponent();
            UpdateItems();
        }

        private void UpdateItems()
        {
            List<Order> orders = BookStoreDbContext.db.Orders.Include(o => o.orderBooks).ThenInclude(ob => ob.Book).ToList();
            //List<Order> orders = BookStoreDbContext.db.Orders.ToList();


            OrdersLV.ItemsSource = null;
            OrdersLV.ItemsSource = orders;
        }

        private void GoOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Order order = (sender as Button).DataContext as Order;



            FrameObject.frame.Navigate(new OrderAdmin(order));
            



        }
    }
}
