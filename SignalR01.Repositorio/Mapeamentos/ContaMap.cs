using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SignalR01.Entidades;

namespace SignalR01.Repositorio.Mapeamentos
{
    public class ContaMap:EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            ToTable("Conta");

            HasKey(c => c.Id);

            Property(c => c.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.Tipo)
                .IsRequired();

            Property(c => c.Valor)
                .HasColumnType("money")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(c => c.Data)
                .HasColumnType("date")
                .IsRequired();

        }
    }
}
