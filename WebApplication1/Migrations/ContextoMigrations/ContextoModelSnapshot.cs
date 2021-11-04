﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.ViewModels;

namespace WebApplication1.Migrations.ContextoMigrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.ViewModels.DashboardViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Checkin")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CHECKIN");

                    b.Property<string>("Checkout")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CHECKOUT");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CLIENTE");

                    b.Property<string>("Distanciakm")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DISTKM");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("HORARIO");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOCAL");

                    b.Property<string>("Suporte")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SUPORTE");

                    b.HasKey("Id");

                    b.ToTable("Agenda");
                });
#pragma warning restore 612, 618
        }
    }
}
