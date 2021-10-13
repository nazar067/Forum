using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class ThemeContext:DbContext
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public ThemeContext(DbContextOptions<ThemeContext> optins):base(optins)
        {
            Database.EnsureCreated();
        }
    }
}
