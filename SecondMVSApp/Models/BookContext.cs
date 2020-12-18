using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecondMVSApp.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }

   public class BookDBInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л.Н.Толстой", Price = 10.25m });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И.Тургенев", Price = 15.50m });
            db.Books.Add(new Book { Name = "Три мушкетера", Author = "А.Дюма", Price = 25.10m });

            base.Seed(db);
        } 
    } 
}