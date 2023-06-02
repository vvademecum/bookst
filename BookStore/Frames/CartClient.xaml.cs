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

namespace BookStore.Frames
{
    /// <summary>
    /// Логика взаимодействия для CartClient.xaml
    /// </summary>
    public partial class CartClient : Page
    {
        public CartClient()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateItems();
        }

        private void UpdateUI()
        {
            if (ClientCart.orderBooks.Count == 0)
            {
                CreateOrder.Visibility = Visibility.Collapsed;
                InfoMessage.Visibility = Visibility.Visible;
            }
            else
            {
                InfoMessage.Visibility = Visibility.Collapsed;
                CreateOrder.Visibility = Visibility.Visible;
            }
        }

        private void UpdateItems()
        {
            List<OrderBook> orderBooks = ClientCart.orderBooks;

            ProductsLV.ItemsSource = null;
            ProductsLV.ItemsSource = orderBooks;
        }

        private double CalculateAmount(List<OrderBook> orderBooks)
        {
            double amount = 0;

            foreach (OrderBook orderBook in orderBooks)
            {
                amount += orderBook.Book.Price * orderBook.Quantity;
            }

            return amount;
        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order()
                {
                    dateTime = DateTime.Now,
                    orderBooks = ClientCart.orderBooks,
                    amountPrice = CalculateAmount(ClientCart.orderBooks),
                };

                BookStoreDbContext.db.Orders.Add(order);
                BookStoreDbContext.db.SaveChanges();

                MessageBox.Show("!!!!!!!!!!!!!!!!!!!!!!");
                //FrameObject.frame.Navigate(new GuestOrderData(order));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteOneQuantity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderBook orderBook = (sender as Button).DataContext as OrderBook;

                if (orderBook.Quantity <= 1)
                {
                    ClientCart.orderBooks.Remove(orderBook);
                }
                else
                {
                    orderBook.Quantity--;
                }
                UpdateItems();
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddOneQuantity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderBook orderBook = (sender as Button).DataContext as OrderBook;

                if (orderBook.Quantity < orderBook.Book.QuantityInStock)
                {
                    orderBook.Quantity++;
                }
                else
                {
                    MessageBox.Show("Выбрано максимальное количество товара");
                }
                UpdateItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
