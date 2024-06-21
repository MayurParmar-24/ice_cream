using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using Microsoft.Build.Framework;

namespace WebApplication2.Data

{
    public class appcontext : DbContext
    {
        public appcontext(DbContextOptions<appcontext> option) : base(option) { 

        }

        public DbSet<contact> contacts { get; set; }
        public DbSet<signup> signups { get; set; }

        public DbSet<login> logins  { get; set; }

        public DbSet<feedback> feedbacks  { get; set; }

        public DbSet<Gallery> galleries { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<addtocart> addtocarts { get; set; }



    }
}
