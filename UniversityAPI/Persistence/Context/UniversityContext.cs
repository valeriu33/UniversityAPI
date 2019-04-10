using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityAPI.Persistence.Models;

namespace UniversityAPI.Persistence.Context
{
    public class UniversityContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=university.db");
        }
    }
}
