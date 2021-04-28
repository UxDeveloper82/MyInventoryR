using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyInventoryR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInventoryR.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Part> Parts { get; set; }

        public DbSet<Techline> Techlines { get; set; }

        public DbSet<Warranty> Warranties { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }

}
