﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240124035231_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Moneda", b =>
                {
                    b.Property<int>("monedaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("monedaID"));

                    b.Property<string>("monedaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("monedaID");

                    b.ToTable("Monedas");
                });

            modelBuilder.Entity("DB.Proveedor", b =>
                {
                    b.Property<int>("proveedorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("proveedorID"));

                    b.Property<string>("proveedorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("proveedorID");

                    b.ToTable("Proveedors");
                });

            modelBuilder.Entity("DB.Recibo", b =>
                {
                    b.Property<int>("reciboID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reciboID"));

                    b.Property<string>("comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("monedaID")
                        .HasColumnType("int");

                    b.Property<float>("monto")
                        .HasColumnType("real");

                    b.Property<int>("proveedorID")
                        .HasColumnType("int");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("reciboID");

                    b.HasIndex("monedaID");

                    b.HasIndex("proveedorID");

                    b.HasIndex("userID");

                    b.ToTable("Reciboes");
                });

            modelBuilder.Entity("DB.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"));

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userRole")
                        .HasColumnType("int");

                    b.HasKey("userID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DB.Recibo", b =>
                {
                    b.HasOne("DB.Moneda", "moneda")
                        .WithMany()
                        .HasForeignKey("monedaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Proveedor", "proveedor")
                        .WithMany()
                        .HasForeignKey("proveedorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.User", "user")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("moneda");

                    b.Navigation("proveedor");

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
