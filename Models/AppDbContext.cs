using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.ViewModel;

namespace WebApplication2.Models
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<UserViewModel> UserViewModel { get; set; }
        public DbSet<LoginViewModel> LoginViewModel { get; set; }
        public DbSet<CustomersDetail> CustomersDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

       

        
    }
}
