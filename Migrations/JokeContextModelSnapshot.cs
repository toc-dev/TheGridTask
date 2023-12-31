﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheGridTask.Console.Models;

#nullable disable

namespace TheGridTask.Console.Migrations
{
    [DbContext(typeof(JokeContext))]
    partial class JokeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TheGridTask.Console.Models.Flags", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Explicit")
                        .HasColumnType("bit");

                    b.Property<bool>("Nsfw")
                        .HasColumnType("bit");

                    b.Property<bool>("Political")
                        .HasColumnType("bit");

                    b.Property<bool>("Racist")
                        .HasColumnType("bit");

                    b.Property<bool>("Religious")
                        .HasColumnType("bit");

                    b.Property<bool>("Sexist")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("TheGridTask.Console.Models.Joke", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Delivery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FlagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Lang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Safe")
                        .HasColumnType("bit");

                    b.Property<string>("Setup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlagId");

                    b.ToTable("Jokes");
                });

            modelBuilder.Entity("TheGridTask.Console.Models.Joke", b =>
                {
                    b.HasOne("TheGridTask.Console.Models.Flags", "Flags")
                        .WithMany()
                        .HasForeignKey("FlagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flags");
                });
#pragma warning restore 612, 618
        }
    }
}
