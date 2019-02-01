﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepairsManager.Dal.Context;

namespace RepairsManager.Dal.Migrations
{
    [DbContext(typeof(RepairsManagerContext))]
    [Migration("20190201094150_initDB")]
    partial class initDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RepairsManager.Dal.Models.Commission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChairmanId");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("Commission");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.CommissionResponsible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommissionId");

                    b.Property<int>("EmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("CommissionId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Commission_responsible");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Defecation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovedId");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<int>("PartId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedId");

                    b.HasIndex("PartId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Defecation");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.DefecationPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("MaterialId");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("('Заменено')")
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.ToTable("Defecation_part");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.DefecationResponsible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DefecationId")
                        .HasColumnName("defecationId");

                    b.Property<int>("EmployeeId")
                        .HasColumnName("employeeId");

                    b.HasKey("Id");

                    b.HasIndex("DefecationId");

                    b.ToTable("Defecation_responsible");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Depreciation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovedId");

                    b.Property<int>("CommissionId");

                    b.Property<int>("DepartmentId");

                    b.Property<int>("MaterialId");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Organization")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("('ИП \"Городская аварийная служба\"')")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("CommissionId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("Number")
                        .IsUnique()
                        .HasName("UQ__Deprecia__78A1A19D22E79269");

                    b.ToTable("Depreciation");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.EmployeeDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__Employee__737584F6093C4264");

                    b.ToTable("Employee_department");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.EmployeePosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__Employee__737584F6121BD772");

                    b.ToTable("Employee_position");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("PartyId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("UnitId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.MaterialParty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Number")
                        .HasMaxLength(16);

                    b.Property<DateTime?>("Receipt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Number")
                        .IsUnique()
                        .HasName("UQ__Material__78A1A19D2DCA0491")
                        .HasFilter("[Number] IS NOT NULL");

                    b.ToTable("Material_party");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.MaterialUnits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__Material__737584F6A82DA201");

                    b.ToTable("Material_units");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<int>("FaultId");

                    b.Property<int>("Speedometer");

                    b.Property<int>("StatusId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("FaultId");

                    b.HasIndex("StatusId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.OrderFault", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.ToTable("Order_fault");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__Order_st__737584F65815BAF6");

                    b.ToTable("Order_status");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DriverId");

                    b.Property<string>("RegNumber")
                        .IsRequired()
                        .HasColumnName("Reg_number")
                        .HasMaxLength(16);

                    b.Property<int>("VehicleModelId");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("RegNumber")
                        .IsUnique()
                        .HasName("UQ__Vehicle__18B201F636734836");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.VehicleMark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__Vehicle___737584F62C8CFEDB");

                    b.ToTable("Vehicle_mark");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("VehicleMarkId");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__Vehicle___737584F6D60374B5");

                    b.HasIndex("VehicleMarkId");

                    b.ToTable("Vehicle_model");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.CommissionResponsible", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.Commission", "Commission")
                        .WithMany("CommissionResponsible")
                        .HasForeignKey("CommissionId")
                        .HasConstraintName("Commission_responsible_fk0");

                    b.HasOne("RepairsManager.Dal.Models.Employee", "Employee")
                        .WithMany("CommissionResponsible")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("Commission_responsible_fk1");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Defecation", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.Employee", "Approved")
                        .WithMany("Defecation")
                        .HasForeignKey("ApprovedId")
                        .HasConstraintName("Defecation_fk2");

                    b.HasOne("RepairsManager.Dal.Models.DefecationPart", "Part")
                        .WithMany("Defecation")
                        .HasForeignKey("PartId")
                        .HasConstraintName("Defecation_fk1");

                    b.HasOne("RepairsManager.Dal.Models.Vehicle", "Vehicle")
                        .WithMany("Defecation")
                        .HasForeignKey("VehicleId")
                        .HasConstraintName("Defecation_fk0");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.DefecationPart", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.Material", "Material")
                        .WithMany("DefecationPart")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("Defecation_part_fk0");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.DefecationResponsible", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.Defecation", "Defecation")
                        .WithMany("DefecationResponsible")
                        .HasForeignKey("DefecationId")
                        .HasConstraintName("Defecation_responsible_fk0");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Depreciation", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.Commission", "Commission")
                        .WithMany("Depreciation")
                        .HasForeignKey("CommissionId")
                        .HasConstraintName("Depreciation_fk2");

                    b.HasOne("RepairsManager.Dal.Models.EmployeeDepartment", "Department")
                        .WithMany("Depreciation")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("Depreciation_fk0");

                    b.HasOne("RepairsManager.Dal.Models.Material", "Material")
                        .WithMany("Depreciation")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("Depreciation_fk3");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Employee", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.EmployeeDepartment", "Department")
                        .WithMany("Employee")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("Employee_fk1");

                    b.HasOne("RepairsManager.Dal.Models.EmployeePosition", "Position")
                        .WithMany("Employee")
                        .HasForeignKey("PositionId")
                        .HasConstraintName("Employee_fk0");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Material", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.MaterialParty", "Party")
                        .WithMany("Material")
                        .HasForeignKey("PartyId")
                        .HasConstraintName("Material_fk0");

                    b.HasOne("RepairsManager.Dal.Models.MaterialUnits", "Unit")
                        .WithMany("Material")
                        .HasForeignKey("UnitId")
                        .HasConstraintName("Material_fk1");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Order", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.OrderFault", "Fault")
                        .WithMany("Order")
                        .HasForeignKey("FaultId")
                        .HasConstraintName("Order_fk2");

                    b.HasOne("RepairsManager.Dal.Models.OrderStatus", "Status")
                        .WithMany("Order")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("Order_fk1");

                    b.HasOne("RepairsManager.Dal.Models.Vehicle", "Vehicle")
                        .WithMany("Order")
                        .HasForeignKey("VehicleId")
                        .HasConstraintName("Order_fk0");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.Vehicle", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.Employee", "Driver")
                        .WithMany("Vehicle")
                        .HasForeignKey("DriverId")
                        .HasConstraintName("Vehicle_fk1");

                    b.HasOne("RepairsManager.Dal.Models.VehicleModel", "VehicleModel")
                        .WithMany("Vehicle")
                        .HasForeignKey("VehicleModelId")
                        .HasConstraintName("Vehicle_fk0");
                });

            modelBuilder.Entity("RepairsManager.Dal.Models.VehicleModel", b =>
                {
                    b.HasOne("RepairsManager.Dal.Models.VehicleMark", "VehicleMark")
                        .WithMany("VehicleModel")
                        .HasForeignKey("VehicleMarkId")
                        .HasConstraintName("Vehicle_model_fk0");
                });
#pragma warning restore 612, 618
        }
    }
}