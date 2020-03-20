using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Models
{
    public class MobileContext : DbContext
    {
        // tvyalneri stacum db-ic
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        //ctor db stexcelu hamar
        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
