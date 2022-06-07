using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MigrateDemo
{
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
    }
    public class BookContext : DbContext 
    { 
        public BookContext() : base("BookContext")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
