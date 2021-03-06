// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalBooksApi.Models.Context;

namespace RentalBooksApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RentalBooksApi.Models.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("author");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<long?>("CategoryId1")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("launch_date");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("price");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.ToTable("books");
                });

            modelBuilder.Entity("RentalBooksApi.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("RentalBooksApi.Models.Book", b =>
                {
                    b.HasOne("RentalBooksApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId1");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
