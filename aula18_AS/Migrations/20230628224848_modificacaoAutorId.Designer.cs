﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aula18_AS.Data.Context;

#nullable disable

namespace aula18_AS.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230628224848_modificacaoAutorId")]
    partial class modificacaoAutorId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("aula18_AS.Domain.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DbSetAutor");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.AutoresLivro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutoresId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LivroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.ToTable("DbSetAutorLivro");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmprestimosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmprestimosId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DbSetEmprestimo");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AutorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodBarras")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroPag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("DbSetLivro");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DbSetUsuario");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.AutoresLivro", b =>
                {
                    b.HasOne("aula18_AS.Domain.Entities.Livro", null)
                        .WithMany("Autores")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Emprestimo", b =>
                {
                    b.HasOne("aula18_AS.Domain.Entities.Livro", "Emprestimos")
                        .WithMany("Alugado")
                        .HasForeignKey("EmprestimosId");

                    b.HasOne("aula18_AS.Domain.Entities.Usuario", null)
                        .WithMany("Emprestimo")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Livro", b =>
                {
                    b.HasOne("aula18_AS.Domain.Entities.Autor", null)
                        .WithMany("Livros")
                        .HasForeignKey("AutorId");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Livro", b =>
                {
                    b.Navigation("Alugado");

                    b.Navigation("Autores");
                });

            modelBuilder.Entity("aula18_AS.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Emprestimo");
                });
#pragma warning restore 612, 618
        }
    }
}