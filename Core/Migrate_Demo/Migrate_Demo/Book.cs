using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrate_Demo
{
    public class Book
    {
        
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
    }
    public class BookContext : DbContext
        {
        public BookContext() : base("BookContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookContext, Migrate_Demo.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Book> Books { get; set; }

}
}
