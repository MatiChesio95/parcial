using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial.Models;

namespace Parcial.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext (DbContextOptions<MenuContext> options)
            : base(options)
        {
        }

        public DbSet<Parcial.Models.Menu> Menu { get; set; } = default!;

        public DbSet<Parcial.Models.Restaurant> Restaurant { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()            
            .HasMany(p=>p.Restaurants)
            .WithMany(p=> p.Menus)
            .UsingEntity("MenuRestaurant");
        }

        
    }
}
