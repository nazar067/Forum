using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class MessageContext:DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public MessageContext(DbContextOptions<MessageContext> optins) : base(optins)
        {
            Database.EnsureCreated();
        }
    }
}
