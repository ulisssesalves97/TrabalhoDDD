using DDD.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infra.Data.Mapping
{
    public class ContaMap : IEntityTypeConfiguration<ContaCorrente>
	{
    public void Configure(EntityTypeBuilder<ContaCorrente> builder)
    {
      builder.ToTable("ContaCorrente");

      builder.HasKey(c => c.Id);

      builder.Property(c =>c.Conta)
        .IsRequired()
        .HasColumnName("Conta");

      builder.Property(c => c.Saldo)
        .IsRequired()
        .HasColumnName("Saldo");

      builder.Property(c => c.LimiteCredito)
        .IsRequired()
        .HasColumnName("LimiteCredito");
    }
	}
}