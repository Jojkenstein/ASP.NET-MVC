﻿// <auto-generated />
using ASP.NET_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.NET_MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230221102948_Seeded some Person data")]
    partial class SeededsomePersondata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASP.NET_MVC.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = "44a4ccec-83d8-4beb-827f-e44ac0144108",
                            City = "Gotemburgo",
                            Name = "Jay Kay",
                            PhoneNumber = "666-692471337"
                        },
                        new
                        {
                            Id = "c78dfab7-a02a-4ae6-8b93-675098bfcdbc",
                            City = "Austin",
                            Name = "Mike Truk",
                            PhoneNumber = "555-302540371"
                        },
                        new
                        {
                            Id = "cbe4c2e3-55b7-43c1-8f8b-bd8b9cf5be26",
                            City = "Tallahassee",
                            Name = "Bobson Dugnut",
                            PhoneNumber = "555-782575942"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
