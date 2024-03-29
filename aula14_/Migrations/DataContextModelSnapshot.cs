﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aula12_entity_frework.Data;

#nullable disable

namespace aula12_entity_frework.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("aula12_entity_frework.Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("aula12_entity_frework.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("aula12_entity_frework.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("aula12_entity_frework.Domain.Entities.Person", b =>
                {
                    b.HasOne("aula12_entity_frework.Domain.Entities.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("aula12_entity_frework.Domain.Entities.Product", b =>
                {
                    b.HasOne("aula12_entity_frework.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("aula12_entity_frework.Domain.Entities.City", b =>
                {
                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
