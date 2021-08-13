﻿// <auto-generated />
using System;
using Loja_de_Instrumentos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Loja_de_Instrumentos.Migrations
{
    [DbContext(typeof(LojaDeInstrumentosContext))]
    [Migration("20210813012629_bla")]
    partial class bla
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Loja_de_Instrumentos.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InstrumentoCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstrumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstrumentoId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Loja_de_Instrumentos.Models.Instrumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instrumento");
                });

            modelBuilder.Entity("Loja_de_Instrumentos.Models.Categoria", b =>
                {
                    b.HasOne("Loja_de_Instrumentos.Models.Instrumento", "Instrumento")
                        .WithMany("Categoria")
                        .HasForeignKey("InstrumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrumento");
                });

            modelBuilder.Entity("Loja_de_Instrumentos.Models.Instrumento", b =>
                {
                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}