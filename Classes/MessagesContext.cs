using ChatStudents_Kylosov.Classes.Common;
using ChatStudents_Kylosov.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatStudents_Kylosov.Classes
{
    public class MessagesContext : DbContext
    {
        public DbSet<Messages> Messages { get; set; }
        public MessagesContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(Config.config);
    }
}
