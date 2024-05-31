﻿﻿using FederataFutbollit.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FederataFutbollit.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Superliga> Superligat { get; set; }
        public DbSet<Selektori> Selektort { get; set; }
        public DbSet<Stafi> Stafi { get; set; }
        public DbSet<Shteti> Shteti { get; set; }
        public DbSet<Kombetarja> Kombetarja { get; set; }
        public DbSet<Lojtaret> Lojtaret { get; set; }
        public DbSet<LojtaretSuperlige> LojtaretSuperlige{ get; set; }
        public DbSet<Roli> Roli { get; set; }
        public DbSet<Stadiumi> Stadiumi { get; set; }
        public DbSet<Kompeticionet> Kompeticionet { get; set; }
        public DbSet<Ndeshja> Ndeshja { get; set; }
        public DbSet<Statusi> Statusi { get; set; }

        public DbSet<Bileta> Biletat { get; set; }
        public DbSet<Ulesja> Uleset { get; set; }

        public DbSet<SektoriUlseve> SektoriUlseve { get; set; }

        public DbSet<Cart> Carts { get; set; }
    public DbSet<CartSeat> CartSeats { get; set; }

        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfigurimi i entiteteve të identitetit
            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.HasKey(r => new { r.UserId, r.RoleId });
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            });

            // Konfigurimi i lidhjeve për Ndeshja
            modelBuilder.Entity<Ndeshja>()
                .HasOne(n => n.Kombetarja)
                .WithMany(k => k.Ndeshjet)
                .HasForeignKey(n => n.KombetarjaId)
                .OnDelete(DeleteBehavior.NoAction);  // Përditëso për të specifikuar OnDelete
        }
    }
}
