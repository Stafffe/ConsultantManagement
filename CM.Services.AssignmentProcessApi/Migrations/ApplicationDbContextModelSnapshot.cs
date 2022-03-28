﻿// <auto-generated />
using System;
using CM.Services.AssignmentProcessApi.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CM.Services.AssignmentProcessApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CM.Services.AssignmentProcessApi.Models.AssignmentProcess", b =>
                {
                    b.Property<Guid>("AssignmentProcessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brocker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Consultant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssignmentProcessId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            AssignmentProcessId = new Guid("804ce16c-37fa-4401-a7b6-5ce00145d256"),
                            Action = "",
                            Brocker = "Nikita",
                            Consultant = "NV",
                            Customer = "Volvo",
                            Description = "DEscription come here",
                            ImageUrl = "https://dotnetmastery.blob.core.windows.net/mango/14.jpg",
                            Length = 0,
                            StartDate = new DateTime(2022, 6, 1, 10, 37, 40, 903, DateTimeKind.Local).AddTicks(2563),
                            Status = "Submitted",
                            Title = "BackEnd"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
