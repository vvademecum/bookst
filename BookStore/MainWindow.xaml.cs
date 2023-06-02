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
using BookStore.Frames;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            if (BookStoreDbContext.db == null)
            {
                BookStoreDbContext.db = new BookStoreDbContext();
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var db = BookStoreDbContext.db;

            try
            {
                User user = db.Users.Include(u => u.Role).Where(u => u.Login.Equals(LoginTxt.Text) && u.Password.Equals(PasswordTxt.Password)).FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }

                switch (user.Role.Name)
                {
                    case "Администратор":
                        OpenWindow(new Admin());
                        break;
                    case "Менеджер":
                        OpenWindow(new Client());
                        break;
                    default:
                        MessageBox.Show("Пользователь c такой ролью не найден.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void OpenWindow(Window window)
        {
            this.Close();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new Registration());
        }

        private void LoginClientBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new Client());
        }
    }
}
