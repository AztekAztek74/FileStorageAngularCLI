﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace Ang.Migrations
{
    [DbContext(typeof(FileDetailContext))]
    partial class FileDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ang.Models.FileDetail", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileSha256")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShaPathDetailFileSha256")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FileId");

                    b.HasIndex("ShaPathDetailFileSha256");

                    b.ToTable("FileDetails");
                });

            modelBuilder.Entity("Ang.Models.ShaPathDetail", b =>
                {
                    b.Property<string>("FileSha256")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FileSha256");

                    b.ToTable("ShaPathDetails");
                });

            modelBuilder.Entity("Ang.Models.FileDetail", b =>
                {
                    b.HasOne("Ang.Models.ShaPathDetail", "ShaPathDetail")
                        .WithMany("FileDetails")
                        .HasForeignKey("ShaPathDetailFileSha256");
                });
#pragma warning restore 612, 618
        }
    }
}
