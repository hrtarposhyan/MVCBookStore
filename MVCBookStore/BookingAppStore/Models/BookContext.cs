using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookingAppStore.Models
{
    public class BookContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchese> Purcheses { get; set; }

    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Պատերազմ և Խաղաղություն", Author = "Լ․ Տոլստոյ", Price = 5600 });
            db.Books.Add(new Book { Name = "Հայրեր և որդիներ", Author = "Ի․ Տուրգենեվ", Price = 3900 });
            db.Books.Add(new Book { Name = "Չայկա", Author = "Ա․ Չեխով", Price = 2500 });

            base.Seed(db);
        }
    }
}