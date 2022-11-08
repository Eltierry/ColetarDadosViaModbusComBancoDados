﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Programa6;

#nullable disable

namespace Programa6.Migrations
{
    [DbContext(typeof(ProgramaContext))]
    [Migration("20221107225612_AtualizarResumoBanco_v5")]
    partial class AtualizarResumoBancov5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Programa6.DadosPrensa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemperaturaPlato01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemperaturaPlato02")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DadosPrensas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("DadosPrensa");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Programa6.ResumoPrensa", b =>
                {
                    b.HasBaseType("Programa6.DadosPrensa");

                    b.HasDiscriminator().HasValue("ResumoPrensa");
                });
#pragma warning restore 612, 618
        }
    }
}
