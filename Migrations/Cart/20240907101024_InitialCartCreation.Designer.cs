﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_dbcontext.Entities;

#nullable disable

namespace dotnet_dbcontext.Migrations.Cart
{
    [DbContext(typeof(CartContext))]
    [Migration("20240907101024_InitialCartCreation")]
    partial class InitialCartCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("cart")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dotnet_dbcontext.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Total")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Carts", "cart");
                });

            modelBuilder.Entity("dotnet_dbcontext.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Products", "cart");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ddafa65d-e579-4193-becf-43921915d304"),
                            Name = "Product 1",
                            Price = 2.3m
                        },
                        new
                        {
                            Id = new Guid("9296c0b6-8e50-49e9-b792-336d6714acd0"),
                            Name = "Product 2",
                            Price = 4.77m
                        },
                        new
                        {
                            Id = new Guid("e0c0e064-dce5-417b-9f66-5536cdffd034"),
                            Name = "Product 3",
                            Price = 1.4m
                        },
                        new
                        {
                            Id = new Guid("fa865b4e-f0fa-4847-b9a6-d1e981d0c86b"),
                            Name = "Product 4",
                            Price = 5.0m
                        },
                        new
                        {
                            Id = new Guid("f0367f15-9d61-4c5e-aad5-042c8f93aec3"),
                            Name = "Product 5",
                            Price = 8.5m
                        },
                        new
                        {
                            Id = new Guid("1f80800e-626e-4f9d-abee-d74e42f17555"),
                            Name = "Product 6",
                            Price = 11.7m
                        },
                        new
                        {
                            Id = new Guid("ae80a65a-3def-4476-83b7-a636ea2a5d6b"),
                            Name = "Product 7",
                            Price = 23.22m
                        },
                        new
                        {
                            Id = new Guid("f5ba74e9-0294-443a-baef-d015626c7359"),
                            Name = "Product 8",
                            Price = 18.0m
                        },
                        new
                        {
                            Id = new Guid("064f7196-51d4-4980-9b2a-8690d5d8ce3e"),
                            Name = "Product 9",
                            Price = 13.9m
                        },
                        new
                        {
                            Id = new Guid("5ebabea3-276b-476a-b7ef-a6885598d784"),
                            Name = "Product 10",
                            Price = 8.6m
                        });
                });

            modelBuilder.Entity("dotnet_dbcontext.Models.Product", b =>
                {
                    b.HasOne("dotnet_dbcontext.Models.Cart", null)
                        .WithMany("Products")
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("dotnet_dbcontext.Models.Cart", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
