﻿// <auto-generated />
using Firefly.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DataAPI.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20171102211031_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Firefly.Domain.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Firefly.Domain.Entrance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionDescription");

                    b.Property<int>("CharacterId");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("MovieMinute");

                    b.Property<string>("SceneName");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Entrance");
                });

            modelBuilder.Entity("Firefly.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CharacterId");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("Firefly.Domain.Entrance", b =>
                {
                    b.HasOne("Firefly.Domain.Character")
                        .WithOne("Entrance")
                        .HasForeignKey("Firefly.Domain.Entrance", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Firefly.Domain.Quote", b =>
                {
                    b.HasOne("Firefly.Domain.Character")
                        .WithMany("Quotes")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
