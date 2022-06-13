﻿// <auto-generated />
using System;
using LensLooker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LensLooker.Data.Migrations
{
    [DbContext(typeof(LensLookerContext))]
    partial class LensLookerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LensLooker.Data.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Canon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nikon"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sony"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Leica"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Pentax"
                        });
                });

            modelBuilder.Entity("LensLooker.Data.Models.Camera", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("BrandId");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("LensLooker.Data.Models.Lens", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AliasOfName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("LensFamilyId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("AliasOfName");

                    b.HasIndex("BrandId");

                    b.HasIndex("LensFamilyId");

                    b.ToTable("Lenses");
                });

            modelBuilder.Entity("LensLooker.Data.Models.LensFamily", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CameraBrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SensorFormat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CameraBrandId");

                    b.ToTable("LensFamilies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CameraBrandId = 1,
                            Name = "EF",
                            SensorFormat = 0
                        },
                        new
                        {
                            Id = 2,
                            CameraBrandId = 1,
                            Name = "EF L",
                            SensorFormat = 0
                        },
                        new
                        {
                            Id = 3,
                            CameraBrandId = 1,
                            Name = "EF-S",
                            SensorFormat = 1
                        },
                        new
                        {
                            Id = 4,
                            CameraBrandId = 1,
                            Name = "RF",
                            SensorFormat = 0
                        },
                        new
                        {
                            Id = 5,
                            CameraBrandId = 1,
                            Name = "RF L",
                            SensorFormat = 0
                        },
                        new
                        {
                            Id = 6,
                            CameraBrandId = 3,
                            Name = "DT",
                            SensorFormat = 1
                        },
                        new
                        {
                            Id = 7,
                            CameraBrandId = 3,
                            Name = "DT G",
                            SensorFormat = 1
                        },
                        new
                        {
                            Id = 8,
                            CameraBrandId = 3,
                            Name = "DT ZA",
                            SensorFormat = 1
                        },
                        new
                        {
                            Id = 9,
                            CameraBrandId = 3,
                            Name = "E",
                            SensorFormat = 1
                        },
                        new
                        {
                            Id = 10,
                            CameraBrandId = 3,
                            Name = "FE",
                            SensorFormat = 0
                        },
                        new
                        {
                            Id = 11,
                            CameraBrandId = 3,
                            Name = "FE G",
                            SensorFormat = 0
                        },
                        new
                        {
                            Id = 12,
                            CameraBrandId = 3,
                            Name = "FE ZA",
                            SensorFormat = 0
                        });
                });

            modelBuilder.Entity("LensLooker.Data.Models.Photo", b =>
                {
                    b.Property<string>("PhotoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CameraName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateTimeShot")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExposureTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("FNumber")
                        .HasColumnType("float");

                    b.Property<int>("Farm")
                        .HasColumnType("int");

                    b.Property<int?>("FocalLengthInMm")
                        .HasColumnType("int");

                    b.Property<bool>("IsExifFetched")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSkipped")
                        .HasColumnType("bit");

                    b.Property<int?>("Iso")
                        .HasColumnType("int");

                    b.Property<string>("LensName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Server")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoId");

                    b.HasIndex("CameraName");

                    b.HasIndex("LensName");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("LensLooker.Data.Models.Camera", b =>
                {
                    b.HasOne("LensLooker.Data.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("LensLooker.Data.Models.Lens", b =>
                {
                    b.HasOne("LensLooker.Data.Models.Lens", "AliasOf")
                        .WithMany()
                        .HasForeignKey("AliasOfName");

                    b.HasOne("LensLooker.Data.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("LensLooker.Data.Models.LensFamily", "LensFamily")
                        .WithMany()
                        .HasForeignKey("LensFamilyId");

                    b.Navigation("AliasOf");

                    b.Navigation("Brand");

                    b.Navigation("LensFamily");
                });

            modelBuilder.Entity("LensLooker.Data.Models.LensFamily", b =>
                {
                    b.HasOne("LensLooker.Data.Models.Brand", "CameraBrand")
                        .WithMany()
                        .HasForeignKey("CameraBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CameraBrand");
                });

            modelBuilder.Entity("LensLooker.Data.Models.Photo", b =>
                {
                    b.HasOne("LensLooker.Data.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraName");

                    b.HasOne("LensLooker.Data.Models.Lens", "Lens")
                        .WithMany("Photos")
                        .HasForeignKey("LensName");

                    b.Navigation("Camera");

                    b.Navigation("Lens");
                });

            modelBuilder.Entity("LensLooker.Data.Models.Lens", b =>
                {
                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
