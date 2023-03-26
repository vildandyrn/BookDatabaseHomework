using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDatabaseHomework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace BookDatabaseHomework
{
    
    public class BookDataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=BooksDb;Trusted_Connection=true;Trust Server Certificate =True;");
        }
    }

}