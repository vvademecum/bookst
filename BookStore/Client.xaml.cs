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
using System.Windows.Shapes;
using BookStore.Utils;
using BookStore.Frames;


namespace BookStore
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();

            FrameObject.frame = ClientFrame;
            FrameObject.frame.Navigate(new MainClient());
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FrameObject.frame.CanGoBack)
            {
                FrameObject.frame.GoBack();
            }
        }

        private void GoMainBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new MainClient());
        }

        private void GoExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientCart.orderBooks.Clear();

            FrameObject.frame = null;

            Window window = new MainWindow();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.Close();
            window.Show();
        }

        private void GoCartBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new CartClient());
        }
    }
}
