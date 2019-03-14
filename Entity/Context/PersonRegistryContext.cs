using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Context
{
    public class PersonRegistryContext : DbContext
    {
        public PersonRegistryContext(DbContextOptions<PersonRegistryContext> options) : base(options)
        {

        }
        public PersonRegistryContext()
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Marriage> Marriages { get; set; }
        public DbSet<PersonRegister> PersonRegisters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Database=PersonRegistryDb;Integrated Security=True");
        }
    }
}
