using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QAnswerAPI.Models
{
    public class AnswerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Answers.db");

        }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>().HasData(
            new Answer() { Id = 1, Body = "Test1", Accepted = true },
            new Answer() { Id = 2, Body = "Test2", Accepted = false }
            );
        }
    }
}
