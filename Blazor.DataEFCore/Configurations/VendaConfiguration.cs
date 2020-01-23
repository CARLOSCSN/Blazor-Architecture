using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataEFCore.Configurations
{
    public class VendaConfiguration
    {
        public VendaConfiguration(EntityTypeBuilder<Venda> entity)
        {
            entity
            .Property(f => f.VendaId)
            .ValueGeneratedOnAdd();

            entity.Property(r => r.ValorComissao)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

            entity.Property(r => r.ValorCompra)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

            entity.Property(r => r.ValorCustoTotal)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

            entity.Property(r => r.ValorFrete1)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

            entity.Property(r => r.ValorFrete2)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

            entity.Property(r => r.ValorLucro)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

            entity.Property(r => r.ValorOutrasDespesas)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

            entity.Property(r => r.ValorVenda)
               .HasColumnType("decimal(16,2)")
               .IsRequired(true);

        }
    }
}