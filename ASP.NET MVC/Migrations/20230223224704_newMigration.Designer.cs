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
    [Migration("20230223224704_newMigration")]
    partial class newMigration
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
                            Id = "b119657e-9d77-4346-92ce-78b473ddddd8",
                            City = "Gotemburgo",
                            Name = "Jay Kay",
                            PhoneNumber = "666-692471337"
                        },
                        new
                        {
                            Id = "26d9df41-598e-4f20-97fe-7b31ba7e94c5",
                            City = "Austin",
                            Name = "Mike Truk",
                            PhoneNumber = "555-302540371"
                        },
                        new
                        {
                            Id = "8c802057-0499-4460-bdd0-0f6c7ad2ca10",
                            City = "Tallahassee",
                            Name = "Bobson Dugnut",
                            PhoneNumber = "555-782575942"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
