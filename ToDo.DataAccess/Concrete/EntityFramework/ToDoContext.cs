using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFramework
{
    public class ToDoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=WISGNDTYAZ974A;Database=Todo;Trusted_Connection=true")
        }

        public DbSet<User> Users { get; set; }
    }
}
