﻿// <auto-generated />
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Book_shop2.Migrations
{
    [DbContext(typeof(MyBookShopContext))]
    [Migration("20181112074904_Alpha4Migr")]
    partial class Alpha4Migr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Book_shop2.Models.book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("author");

                    b.Property<string>("genre");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<int>("year");

                    b.HasKey("id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Book_shop2.Models.client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int>("Order_id");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Book_shop2.Models.order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Book_id");

                    b.Property<int>("Cost");

                    b.Property<int>("Count");

                    b.Property<string>("Courier_name");

                    b.Property<int>("Customer_id");

                    b.Property<string>("Date_on");

                    b.Property<string>("Date_to");

                    b.Property<int>("Prise");

                    b.Property<string>("Status");

                    b.Property<int>("Stuff_id");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Book_shop2.Models.purchase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("book_id");

                    b.Property<int>("cost");

                    b.Property<int>("count");

                    b.Property<int>("price");

                    b.Property<string>("year");

                    b.HasKey("id");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Book_shop2.Models.stock", b =>
                {
                    b.Property<int>("Book_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int>("Supply_id");

                    b.HasKey("Book_id");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Book_shop2.Models.supply", b =>
                {
                    b.Property<int>("Supply_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Book_id");

                    b.Property<int>("Cost");

                    b.Property<int>("Count");

                    b.Property<string>("Date");

                    b.Property<int>("Price");

                    b.Property<int>("Provider_id");

                    b.HasKey("Supply_id");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("Book_shop2.Models.user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
