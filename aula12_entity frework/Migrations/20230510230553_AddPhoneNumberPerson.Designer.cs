﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aula12_entity_frework.Data;

#nullable disable

namespace aula12_entity_frework.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230510230553_AddPhoneNumberPerson")]
    partial class AddPhoneNumberPerson
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("aula12_entity_frework.Domain.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}
