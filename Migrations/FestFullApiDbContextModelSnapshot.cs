﻿// <auto-generated />
using System;
using System.Collections.Generic;
using FestfullApi.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FestfullApi.Migrations
{
    [DbContext(typeof(FestFullApiDbContext))]
    partial class FestFullApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FestfullApi.Models.Companion", b =>
                {
                    b.Property<long>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("companion_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CompanionId"));

                    b.Property<bool>("DogCkeker")
                        .HasColumnType("boolean")
                        .HasColumnName("dog_checker");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstLastName")
                        .HasColumnType("text")
                        .HasColumnName("f_last_name");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("f_name");

                    b.Property<long>("GuestId")
                        .HasColumnType("bigint")
                        .HasColumnName("guest_id");

                    b.Property<string>("SecondName")
                        .HasColumnType("text")
                        .HasColumnName("s_name");

                    b.Property<string>("secondLastName")
                        .HasColumnType("text")
                        .HasColumnName("s_last_name");

                    b.HasKey("CompanionId");

                    b.HasIndex("GuestId");

                    b.ToTable("companions");
                });

            modelBuilder.Entity("FestfullApi.Models.Event", b =>
                {
                    b.Property<long>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("event_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("EventId"));

                    b.Property<long>("ChairPerTable")
                        .HasColumnType("bigint")
                        .HasColumnName("chairs_per_table");

                    b.Property<DateOnly>("CreationEventDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("date")
                        .HasColumnName("Event_stamp");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("event_Date");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("event_name");

                    b.Property<long>("Tables")
                        .HasColumnType("bigint")
                        .HasColumnName("tables");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FestfullApi.Models.Guest", b =>
                {
                    b.Property<long>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("guest_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("GuestId"));

                    b.Property<bool>("Alcoholchecker")
                        .HasColumnType("boolean")
                        .HasColumnName("alcohol_checker");

                    b.Property<List<string>>("Alergies")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("alergies");

                    b.Property<DateOnly>("BirthDay")
                        .HasColumnType("date")
                        .HasColumnName("b_day");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<long>("EventId")
                        .HasColumnType("bigint")
                        .HasColumnName("evetn_id");

                    b.Property<string>("FirstLastName")
                        .HasColumnType("text")
                        .HasColumnName("f_last_name");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("f_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("pass_word");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<string>("SecondName")
                        .HasColumnType("text")
                        .HasColumnName("s_name");

                    b.Property<string>("secondLastName")
                        .HasColumnType("text")
                        .HasColumnName("s_last_name");

                    b.HasKey("GuestId");

                    b.HasIndex("EventId");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("FestfullApi.Models.Companion", b =>
                {
                    b.HasOne("FestfullApi.Models.Guest", "guestFK")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("guestFK");
                });

            modelBuilder.Entity("FestfullApi.Models.Guest", b =>
                {
                    b.HasOne("FestfullApi.Models.Event", "EventFK")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFK");
                });
#pragma warning restore 612, 618
        }
    }
}
