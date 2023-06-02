using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для MainClient.xaml
    /// </summary>
    public partial class MainClient : Page
    {
        public MainClient()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            List<Book> books = BookStoreDbContext.db.Books.ToList();

            ProductsLstV.ItemsSource = null;
            ProductsLstV.ItemsSource = books;
        }

        private void AdToCartBtn_Click(object sender, RoutedEventArgs e)
        {
            try{
                Book book = (sender as Button).DataContext as Book;

                ClientCart.orderBooks.Add(new OrderBook()
                {
                    Book = book,
                    Quantity = 1
                });
                UpdateProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }

    public class BookInCartConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                int idBook = (int)value;

                //MessageBox.Show(ClientCart.orderBooks.Select(ob => ob.Book.Id).ToString());

                return ClientCart.orderBooks.Select(ob => ob.Book.Id).Contains(idBook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
