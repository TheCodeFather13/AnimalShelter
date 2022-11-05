﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataAnimals.Sql.Repositories;

#nullable disable

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    [DbContext(typeof(AnimalShelterDbContext))]
    partial class AnimalShelterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AnimalShelter.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalId"), 1L, 1);

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Contacts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DayOfPublication")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = "1 месяц",
                            CategoryId = 1,
                            Contacts = "Maria 079245611",
                            DayOfPublication = new DateTime(2022, 11, 3, 17, 33, 53, 498, DateTimeKind.Utc).AddTicks(6365),
                            Gender = "Female",
                            ImagePath = "css/Images/Cat1.jpg",
                            Name = "Муся"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = "5 месяцев",
                            CategoryId = 1,
                            Contacts = "Svetlana 069367315",
                            DayOfPublication = new DateTime(2022, 11, 3, 17, 33, 53, 498, DateTimeKind.Utc).AddTicks(6367),
                            Gender = "Male",
                            ImagePath = "css/Images/Cat2.jpg",
                            Name = "Вася"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = "1 год",
                            CategoryId = 1,
                            Contacts = "Georgii 079996377",
                            DayOfPublication = new DateTime(2022, 11, 3, 17, 33, 53, 498, DateTimeKind.Utc).AddTicks(6368),
                            Gender = "Female",
                            ImagePath = "css/Images/Cat3.jpg",
                            Name = "Бусинка"
                        });
                });

            modelBuilder.Entity("AnimalShelterCore.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Cats"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Dogs"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Animal", b =>
                {
                    b.HasOne("AnimalShelterCore.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AnimalShelterCore.Category", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}