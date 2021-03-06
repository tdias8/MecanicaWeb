﻿// <auto-generated />
using MecanicaWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MecanicaWeb.Migrations
{
    [DbContext(typeof(MecanicaWebContext))]
    [Migration("20190502023520_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MecanicaWeb.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ativo");

                    b.Property<int>("cpf");

                    b.Property<int>("dataDeNascimento");

                    b.Property<string>("email");

                    b.Property<string>("endereco");

                    b.Property<string>("estadoCivil");

                    b.Property<int>("fone");

                    b.Property<string>("nome");

                    b.Property<string>("sexo");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
