using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Models
{
    public class Context : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PedidosFormDb;
                Trusted_Connection=true");
        }
    }
}
