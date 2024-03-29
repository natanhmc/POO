﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aula15_Ap2.Data;

#nullable disable

namespace aula08_ap1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230524030327_AddDateAndOperOnTransacao")]
    partial class AddDateAndOperOnTransacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("aula15_Ap2.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EnderecosId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double>("Saldo")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("EnderecosId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("aula15_Ap2.Domain.Entities.Enderecos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rua")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("aula15_Ap2.Domain.Entities.TransacoesBancarias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Operacao")
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.Property<int?>("clienteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.ToTable("TransacoesBancarias");
                });

            modelBuilder.Entity("aula15_Ap2.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("aula15_Ap2.Domain.Entities.Enderecos", "Enderecos")
                        .WithMany()
                        .HasForeignKey("EnderecosId");

                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("aula15_Ap2.Domain.Entities.TransacoesBancarias", b =>
                {
                    b.HasOne("aula15_Ap2.Domain.Entities.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId");

                    b.Navigation("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
