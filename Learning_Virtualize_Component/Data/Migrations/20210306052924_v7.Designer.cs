﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210306052924_v7")]
    partial class v7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("IndicatorsOfClusters", b =>
                {
                    b.Property<Guid>("ClusterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IndicatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClusterId", "IndicatorId");

                    b.HasIndex("IndicatorId");

                    b.ToTable("IndicatorsOfClusters");
                });

            modelBuilder.Entity("Models.Cluster", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Ordering")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clusters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"),
                            InsertDateTime = new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(6854),
                            IsDeleted = false,
                            Name = "مدیریت توسعه پایدار",
                            Ordering = 0
                        },
                        new
                        {
                            Id = new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"),
                            InsertDateTime = new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(8534),
                            IsDeleted = false,
                            Name = "مدیریت زیبوم",
                            Ordering = 0
                        },
                        new
                        {
                            Id = new Guid("69d98efe-e507-4e68-830e-021324eb2da8"),
                            InsertDateTime = new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(8559),
                            IsDeleted = false,
                            Name = "مدیریت تجارت الکترونیک",
                            Ordering = 0
                        },
                        new
                        {
                            Id = new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"),
                            InsertDateTime = new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(8567),
                            IsDeleted = false,
                            Name = "مدیریت پست و لجستیک",
                            Ordering = 0
                        });
                });

            modelBuilder.Entity("Models.ClusterCost", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClusterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DateRangeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("DeviationPercent")
                        .HasColumnType("float");

                    b.Property<Guid>("IndicatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double?>("PerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("RealValue")
                        .HasColumnType("float");

                    b.Property<double?>("RealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("TargetValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClusterId");

                    b.HasIndex("DateRangeId");

                    b.HasIndex("IndicatorId");

                    b.ToTable("ClusterCosts");
                });

            modelBuilder.Entity("Models.DateRange", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DateRanges");
                });

            modelBuilder.Entity("Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Models.HeadquarterCost", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DateRangeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("DeviationPercent")
                        .HasColumnType("float");

                    b.Property<byte>("HeadquarterIndicatorType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double?>("PerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("RealValue")
                        .HasColumnType("float");

                    b.Property<double?>("RealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("TargetValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DateRangeId");

                    b.ToTable("HeadquarterCosts");
                });

            modelBuilder.Entity("Models.Income", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClusterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DateRangeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("FirstWeekPerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("FirstWeekRealValue")
                        .HasColumnType("float");

                    b.Property<double?>("FirstWeekRealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("FirstWeekTargetValue")
                        .HasColumnType("float");

                    b.Property<double?>("FourMonthsOKRPerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("FourMonthsOKRRealValue")
                        .HasColumnType("float");

                    b.Property<double?>("FourMonthsOKRRealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("FourMonthsOKRTargetValue")
                        .HasColumnType("float");

                    b.Property<double?>("FourthWeekPerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("FourthWeekRealValue")
                        .HasColumnType("float");

                    b.Property<double?>("FourthWeekRealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("FourthWeekTargetValue")
                        .HasColumnType("float");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double?>("MonthPerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("MonthRealValue")
                        .HasColumnType("float");

                    b.Property<double?>("MonthRealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("MonthTargetValue")
                        .HasColumnType("float");

                    b.Property<double?>("SecondWeekPerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("SecondWeekRealValue")
                        .HasColumnType("float");

                    b.Property<double?>("SecondWeekRealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("SecondWeekTargetValue")
                        .HasColumnType("float");

                    b.Property<double?>("ThirdWeekPerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("ThirdWeekRealValue")
                        .HasColumnType("float");

                    b.Property<double?>("ThirdWeekRealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("ThirdWeekTargetValue")
                        .HasColumnType("float");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.Property<double?>("YearlyPerformancePercent")
                        .HasColumnType("float");

                    b.Property<double?>("YearlyRealValue")
                        .HasColumnType("float");

                    b.Property<double?>("YearlyRealizationPercent")
                        .HasColumnType("float");

                    b.Property<double?>("YearlyTargetValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClusterId");

                    b.HasIndex("DateRangeId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("Models.Indicator", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Ordering")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Indicator");
                });

            modelBuilder.Entity("Models.Operation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("AccessType")
                        .HasColumnType("tinyint");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CellPhoneNumber")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)");

                    b.Property<Guid?>("DeletedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(254)
                        .IsUnicode(false)
                        .HasColumnType("varchar(254)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NationalCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"),
                            CellPhoneNumber = "09120717168",
                            FullName = "محسن فرخی",
                            InsertDateTime = new DateTime(2021, 3, 6, 8, 59, 24, 39, DateTimeKind.Local).AddTicks(7395),
                            IsActive = true,
                            IsDeleted = false,
                            Password = "5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8",
                            Type = 900,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("OperationsOfGroups", b =>
                {
                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OperationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GroupId", "OperationId");

                    b.HasIndex("OperationId");

                    b.ToTable("OperationsOfGroups");
                });

            modelBuilder.Entity("UsersOfGroups", b =>
                {
                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GroupId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersOfGroups");
                });

            modelBuilder.Entity("IndicatorsOfClusters", b =>
                {
                    b.HasOne("Models.Cluster", null)
                        .WithMany()
                        .HasForeignKey("ClusterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.Indicator", null)
                        .WithMany()
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.ClusterCost", b =>
                {
                    b.HasOne("Models.Cluster", "Cluster")
                        .WithMany("ClusterCosts")
                        .HasForeignKey("ClusterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.DateRange", "DateRange")
                        .WithMany("ClusterCosts")
                        .HasForeignKey("DateRangeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.Indicator", "Indicator")
                        .WithMany("ClusterCosts")
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cluster");

                    b.Navigation("DateRange");

                    b.Navigation("Indicator");
                });

            modelBuilder.Entity("Models.DateRange", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany("DateRanges")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.HeadquarterCost", b =>
                {
                    b.HasOne("Models.DateRange", "DateRange")
                        .WithMany("HeadquarterCosts")
                        .HasForeignKey("DateRangeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DateRange");
                });

            modelBuilder.Entity("Models.Income", b =>
                {
                    b.HasOne("Models.Cluster", "Cluster")
                        .WithMany("Incomes")
                        .HasForeignKey("ClusterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.DateRange", "DateRange")
                        .WithMany("Incomes")
                        .HasForeignKey("DateRangeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cluster");

                    b.Navigation("DateRange");
                });

            modelBuilder.Entity("Models.Operation", b =>
                {
                    b.HasOne("Models.Operation", "Parent")
                        .WithMany("Operations")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("OperationsOfGroups", b =>
                {
                    b.HasOne("Models.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.Operation", null)
                        .WithMany()
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("UsersOfGroups", b =>
                {
                    b.HasOne("Models.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Cluster", b =>
                {
                    b.Navigation("ClusterCosts");

                    b.Navigation("Incomes");
                });

            modelBuilder.Entity("Models.DateRange", b =>
                {
                    b.Navigation("ClusterCosts");

                    b.Navigation("HeadquarterCosts");

                    b.Navigation("Incomes");
                });

            modelBuilder.Entity("Models.Indicator", b =>
                {
                    b.Navigation("ClusterCosts");
                });

            modelBuilder.Entity("Models.Operation", b =>
                {
                    b.Navigation("Operations");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Navigation("DateRanges");
                });
#pragma warning restore 612, 618
        }
    }
}
