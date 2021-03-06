﻿// <auto-generated />
using System;
using Medgrupo.Contacts.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medgrupo.Contacts.Infra.Migrations
{
    [DbContext(typeof(ContactsDbContext))]
    partial class ContactsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medgrupo.Contacts.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(160);

                    b.HasKey("Id");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1105d51c-0a7c-4b7c-9ba8-74d281225ee5"),
                            Age = 36,
                            Birth = new DateTime(1984, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2020, 7, 6, 14, 48, 0, 270, DateTimeKind.Local).AddTicks(1866),
                            Gender = "Masculino",
                            LastUpdateDate = new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5248),
                            Name = "Leonardo"
                        },
                        new
                        {
                            Id = new Guid("0c64891e-fe36-4394-9e1d-e2b8ad075c2d"),
                            Age = 5,
                            Birth = new DateTime(2015, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5646),
                            Gender = "Masculino",
                            LastUpdateDate = new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5754),
                            Name = "Arthur"
                        },
                        new
                        {
                            Id = new Guid("232947ae-717b-4ae6-8e29-40af4e6f455a"),
                            Age = 66,
                            Birth = new DateTime(1954, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5764),
                            Gender = "Feminino",
                            LastUpdateDate = new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5773),
                            Name = "Aidenir"
                        },
                        new
                        {
                            Id = new Guid("c2652a8b-628d-4d13-a767-03058f7e7c21"),
                            Age = 26,
                            Birth = new DateTime(1994, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5778),
                            Gender = "Feminino",
                            LastUpdateDate = new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5784),
                            Name = "Ana Paula"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
