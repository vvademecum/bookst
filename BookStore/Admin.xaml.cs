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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();

            FrameObject.frame = AdminFrame;
            FrameObject.frame.Navigate(new MainAdmin());
        }

        private void GoExitBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame = null;

            Window window = new MainWindow();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.Close();
            window.Show();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoMainBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
