﻿// <auto-generated />
using System;
using DemoCaseGui.Core.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoCaseGui.Core.Migrations
{
    [DbContext(typeof(KEP_Server_DBContext))]
    partial class KEP_Server_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Vietnamese_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoCaseGui.Core.Application.Models.InverterLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_NAME");

                    b.Property<int?>("Numericid")
                        .HasColumnType("int")
                        .HasColumnName("_NUMERICID");

                    b.Property<int?>("Quality")
                        .HasColumnType("int")
                        .HasColumnName("_QUALITY");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("_TIMESTAMP");

                    b.Property<string>("Value")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_VALUE");

                    b.HasKey("Id");

                    b.ToTable("Inverter_LOG", (string)null);
                });

            modelBuilder.Entity("DemoCaseGui.Core.Application.Models.ValiCompactLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_NAME");

                    b.Property<int?>("Numericid")
                        .HasColumnType("int")
                        .HasColumnName("_NUMERICID");

                    b.Property<int?>("Quality")
                        .HasColumnType("int")
                        .HasColumnName("_QUALITY");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("_TIMESTAMP");

                    b.Property<string>("Value")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_VALUE");

                    b.HasKey("Id");

                    b.ToTable("ValiCompact_LOG", (string)null);
                });

            modelBuilder.Entity("DemoCaseGui.Core.Application.Models.ValiIfmLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_NAME");

                    b.Property<int?>("Numericid")
                        .HasColumnType("int")
                        .HasColumnName("_NUMERICID");

                    b.Property<int?>("Quality")
                        .HasColumnType("int")
                        .HasColumnName("_QUALITY");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("_TIMESTAMP");

                    b.Property<string>("Value")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_VALUE");

                    b.HasKey("Id");

                    b.ToTable("ValiIFM_LOG", (string)null);
                });

            modelBuilder.Entity("DemoCaseGui.Core.Application.Models.ValiMicroLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_NAME");

                    b.Property<int?>("Numericid")
                        .HasColumnType("int")
                        .HasColumnName("_NUMERICID");

                    b.Property<int?>("Quality")
                        .HasColumnType("int")
                        .HasColumnName("_QUALITY");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("_TIMESTAMP");

                    b.Property<string>("Value")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_VALUE");

                    b.HasKey("Id");

                    b.ToTable("ValiMicro_LOG", (string)null);
                });
            modelBuilder.Entity("DemoCaseGui.Core.Application.Models.ValiMicro820Log", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("id");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("_NAME");

                b.Property<int?>("Numericid")
                    .HasColumnType("int")
                    .HasColumnName("_NUMERICID");

                b.Property<int?>("Quality")
                    .HasColumnType("int")
                    .HasColumnName("_QUALITY");

                b.Property<DateTime>("Timestamp")
                    .HasColumnType("datetime")
                    .HasColumnName("_TIMESTAMP");

                b.Property<string>("Value")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("_VALUE");

                b.HasKey("Id");

                b.ToTable("ValiMicro820_LOG", (string)null);
            });
            modelBuilder.Entity("DemoCaseGui.Core.Application.Models.ValiSiemensLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_NAME");

                    b.Property<int?>("Numericid")
                        .HasColumnType("int")
                        .HasColumnName("_NUMERICID");

                    b.Property<int?>("Quality")
                        .HasColumnType("int")
                        .HasColumnName("_QUALITY");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("_TIMESTAMP");

                    b.Property<string>("Value")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("_VALUE");

                    b.HasKey("Id");

                    b.ToTable("ValiSiemens_LOG", (string)null);
                });
            modelBuilder.Entity("DemoCaseGui.Core.Application.Models.StepMotorLog", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("id");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("_NAME");

                b.Property<int?>("Numericid")
                    .HasColumnType("int")
                    .HasColumnName("_NUMERICID");

                b.Property<int?>("Quality")
                    .HasColumnType("int")
                    .HasColumnName("_QUALITY");

                b.Property<DateTime>("Timestamp")
                    .HasColumnType("datetime")
                    .HasColumnName("_TIMESTAMP");

                b.Property<string>("Value")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("_VALUE");

                b.HasKey("Id");

                b.ToTable("StepMotor_LOG", (string)null);
            });

#pragma warning restore 612, 618
        }
    }
}
