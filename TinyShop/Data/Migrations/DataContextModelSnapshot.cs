﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Data.ProductDO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Price")
                        .HasMaxLength(100);

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<string>("ProductNumber")
                        .HasMaxLength(100);

                    b.Property<string>("ProductType")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
