using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;


namespace BookStore.Utils
{
    internal class BookStoreDbContext: DbContext
    {
        public static BookStoreDbContext db;
        private static string connectionString = "Data Source=NIKOLAY\\MSSQLSERVER01;Database=bookStoreDB; Integrated Security=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<OrderBook> OrderBooks { get; set; }

        public virtual DbSet<Status> Statuses { get; set; }

        public virtual DbSet<Order> Orders{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
