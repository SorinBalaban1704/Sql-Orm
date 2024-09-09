using Microsoft.EntityFrameworkCore;
using Sql_ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM
{
    public  class BankBD : DbContext
    {
        public DbSet<Member> Members => Set<Member>();
        public DbSet<ProfileMember> Profiles => Set<ProfileMember>();
        public DbSet<Comanda> Comand => Set<Comanda>();
        public DbSet<Produs> Produs => Set<Produs>();
        public DbSet<DetaliiComanda> DetaliiComenzi => Set<DetaliiComanda>();   
        
        public BankBD() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = helloapp.db");
        }
    }
}
