﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valasztasok.Model;

#nullable disable

namespace Valasztasok.Migrations
{
    [DbContext(typeof(ValasztasokDbContext))]
    [Migration("20240926070908_sqlite.local_migration_679")]
    partial class sqlitelocal_migration_679
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Valasztasok.Model.Jelolt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KepviseloNev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("KeruletID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PartRovidNev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SzavazatSzam")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PartRovidNev");

                    b.ToTable("Jeloltek");
                });

            modelBuilder.Entity("Valasztasok.Model.Part", b =>
                {
                    b.Property<string>("RovidNev")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeljesNev")
                        .HasColumnType("TEXT");

                    b.HasKey("RovidNev");

                    b.ToTable("Partok");
                });

            modelBuilder.Entity("Valasztasok.Model.Jelolt", b =>
                {
                    b.HasOne("Valasztasok.Model.Part", "Part")
                        .WithMany("Jeloltek")
                        .HasForeignKey("PartRovidNev")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");
                });

            modelBuilder.Entity("Valasztasok.Model.Part", b =>
                {
                    b.Navigation("Jeloltek");
                });
#pragma warning restore 612, 618
        }
    }
}
