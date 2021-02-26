using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Context
{
    public class MediatorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-2QF0S4K;Initial Catalog=MediatorDb;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
