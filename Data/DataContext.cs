using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDotNetProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstDotNetProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<User> users { get; set; }
    }
}