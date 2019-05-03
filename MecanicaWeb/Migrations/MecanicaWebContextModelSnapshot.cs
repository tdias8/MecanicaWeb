﻿// <auto-generated />
using System;
using MecanicaWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MecanicaWeb.Migrations
{
    [DbContext(typeof(MecanicaWebContext))]
    partial class MecanicaWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MecanicaWeb.Models.Agenda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("data");

                    b.Property<DateTime>("hora");

                    b.HasKey("id");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("MecanicaWeb.Models.Atendimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Clienteid");

                    b.Property<int?>("Profissionalid");

                    b.Property<DateTime>("data");

                    b.Property<string>("descricao");

                    b.Property<DateTime>("hora");

                    b.Property<int>("status");

                    b.HasKey("id");

                    b.HasIndex("Clienteid");

                    b.HasIndex("Profissionalid");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("MecanicaWeb.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ativo");

                    b.Property<double>("cpf");

                    b.Property<DateTime>("dataDeNascimento");

                    b.Property<string>("email");

                    b.Property<string>("endereco");

                    b.Property<string>("estadoCivil");

                    b.Property<double>("fone");

                    b.Property<string>("nome");

                    b.Property<string>("sexo");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("MecanicaWeb.Models.Profissional", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Agendaid");

                    b.Property<string>("email");

                    b.Property<double>("fone");

                    b.Property<string>("nome");

                    b.HasKey("id");

                    b.HasIndex("Agendaid");

                    b.ToTable("Profissional");
                });

            modelBuilder.Entity("MecanicaWeb.Models.Atendimento", b =>
                {
                    b.HasOne("MecanicaWeb.Models.Cliente")
                        .WithMany("Atendimentos")
                        .HasForeignKey("Clienteid");

                    b.HasOne("MecanicaWeb.Models.Profissional")
                        .WithMany("Atendimentos")
                        .HasForeignKey("Profissionalid");
                });

            modelBuilder.Entity("MecanicaWeb.Models.Profissional", b =>
                {
                    b.HasOne("MecanicaWeb.Models.Agenda")
                        .WithMany("Profissionais")
                        .HasForeignKey("Agendaid");
                });
#pragma warning restore 612, 618
        }
    }
}
