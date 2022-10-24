﻿// <auto-generated />
using System;
using Faturamento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Faturamento.Migrations
{
    [DbContext(typeof(FaturamentoContext))]
    partial class FaturamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Faturamento.Models.Distribuidora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Distribuidoras");
                });

            modelBuilder.Entity("Faturamento.Models.Fatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DistribuidoraId");

                    b.Property<DateTime>("dia");

                    b.Property<double>("valor");

                    b.HasKey("Id");

                    b.HasIndex("DistribuidoraId");

                    b.ToTable("Faturas");
                });

            modelBuilder.Entity("Faturamento.Models.Fatura", b =>
                {
                    b.HasOne("Faturamento.Models.Distribuidora", "Distribuidora")
                        .WithMany("Fatura")
                        .HasForeignKey("DistribuidoraId");
                });
#pragma warning restore 612, 618
        }
    }
}
