﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp1.Data;

#nullable disable

namespace WebApp1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241101021902_AddFile")]
    partial class AddFile
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp1.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageBase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 3,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone1",
                            Price = 61.0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 3,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone2",
                            Price = 45.0
                        },
                        new
                        {
                            Id = 3,
                            Amount = 6,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone3",
                            Price = 89.0
                        },
                        new
                        {
                            Id = 4,
                            Amount = 4,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone4",
                            Price = 32.0
                        },
                        new
                        {
                            Id = 5,
                            Amount = 1,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone5",
                            Price = 39.0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 5,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone6",
                            Price = 84.0
                        },
                        new
                        {
                            Id = 7,
                            Amount = 8,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone7",
                            Price = 27.0
                        },
                        new
                        {
                            Id = 8,
                            Amount = 5,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone8",
                            Price = 68.0
                        },
                        new
                        {
                            Id = 9,
                            Amount = 3,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone9",
                            Price = 63.0
                        },
                        new
                        {
                            Id = 10,
                            Amount = 7,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone10",
                            Price = 51.0
                        },
                        new
                        {
                            Id = 11,
                            Amount = 4,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone11",
                            Price = 92.0
                        },
                        new
                        {
                            Id = 12,
                            Amount = 9,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone12",
                            Price = 79.0
                        },
                        new
                        {
                            Id = 13,
                            Amount = 6,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone13",
                            Price = 58.0
                        },
                        new
                        {
                            Id = 14,
                            Amount = 2,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone14",
                            Price = 63.0
                        },
                        new
                        {
                            Id = 15,
                            Amount = 2,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone15",
                            Price = 13.0
                        },
                        new
                        {
                            Id = 16,
                            Amount = 9,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone16",
                            Price = 11.0
                        },
                        new
                        {
                            Id = 17,
                            Amount = 9,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone17",
                            Price = 77.0
                        },
                        new
                        {
                            Id = 18,
                            Amount = 7,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone18",
                            Price = 35.0
                        },
                        new
                        {
                            Id = 19,
                            Amount = 1,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone19",
                            Price = 22.0
                        },
                        new
                        {
                            Id = 20,
                            Amount = 5,
                            Image = "",
                            ImageBase64 = "",
                            Name = "MicroPhone20",
                            Price = 35.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}