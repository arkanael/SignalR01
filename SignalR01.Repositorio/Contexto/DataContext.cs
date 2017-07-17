using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SignalR01.Repositorio.Mapeamentos;
using SignalR01.Entidades.Tipo;

using SignalR01.Entidades;

namespace SignalR01.Repositorio.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext():base("Base")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContaMap());

        }

        public DbSet<Conta> Conta { get; set; }
    }
}
