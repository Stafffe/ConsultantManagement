﻿// <auto-generated />
using System;
using CM.Services.AssignmentApi.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CM.Services.AssignmentApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220222212604_c2")]
    partial class c2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment", b =>
                {
                    b.Property<Guid>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssignmentId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Assignment_Categories");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment_Length", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LengthId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("LengthId");

                    b.ToTable("Assignment_Lengths");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment_Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("TypeId");

                    b.ToTable("Assignment_Types");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.AssignmentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AssignmentTypes");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Length", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lengths");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Specification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment_Category", b =>
                {
                    b.HasOne("CM.Services.AssignmentApi.Models.Assignment", "Assignment")
                        .WithMany("Assignment_Category")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CM.Services.AssignmentApi.Models.Category", "Category")
                        .WithMany("Assignment_Category")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment_Length", b =>
                {
                    b.HasOne("CM.Services.AssignmentApi.Models.Assignment", "Assignment")
                        .WithMany("Assignment_Length")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CM.Services.AssignmentApi.Models.Length", "Length")
                        .WithMany("Assignment_Length")
                        .HasForeignKey("LengthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Length");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment_Type", b =>
                {
                    b.HasOne("CM.Services.AssignmentApi.Models.Assignment", "Assignment")
                        .WithMany("Assignment_Type")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CM.Services.AssignmentApi.Models.AssignmentType", "AssignmentType")
                        .WithMany("Assignment_Type")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("AssignmentType");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Specification", b =>
                {
                    b.HasOne("CM.Services.AssignmentApi.Models.Assignment", "Assignment")
                        .WithMany("Specifications")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Assignment", b =>
                {
                    b.Navigation("Assignment_Category");

                    b.Navigation("Assignment_Length");

                    b.Navigation("Assignment_Type");

                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.AssignmentType", b =>
                {
                    b.Navigation("Assignment_Type");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Category", b =>
                {
                    b.Navigation("Assignment_Category");
                });

            modelBuilder.Entity("CM.Services.AssignmentApi.Models.Length", b =>
                {
                    b.Navigation("Assignment_Length");
                });
#pragma warning restore 612, 618
        }
    }
}