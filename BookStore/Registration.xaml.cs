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
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using BookStore.Utils;



namespace BookStore
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();

            if (BookStoreDbContext.db == null)
            {
                BookStoreDbContext.db = new BookStoreDbContext();
            }
        }

        private void GoRegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            var db = BookStoreDbContext.db;

            try
            {
                Role role = db.Roles.Where(r => r.Name.Equals("Клиент")).FirstOrDefault();
                User user = new User() { Name = Name.Text.Trim(), 
                                        Surname = Surname.Text.Trim(),
                                        Patronymic = Patronymic.Text.Trim(),
                                        Login = Login.Text.Trim(),
                                        Password = Password.Password.Trim(),
                                        Role = role};
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();

            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.Close();
            window.Show();
        }
    }
}
