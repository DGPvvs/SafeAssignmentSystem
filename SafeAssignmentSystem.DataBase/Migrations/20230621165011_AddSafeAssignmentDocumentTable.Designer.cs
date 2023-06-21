﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SafeAssignmentSystem.Core.Data;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    [DbContext(typeof(SafeAssignmentDbContext))]
    [Migration("20230621165011_AddSafeAssignmentDocumentTable")]
    partial class AddSafeAssignmentDocumentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Собствено име на потребител");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Фамилно име на потребител");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserWorkNumber")
                        .HasColumnType("int")
                        .HasComment("Табелен номер на потребителя");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasComment("Модел на потребителите");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUserPlantInstalation", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Id на потребител");

                    b.Property<Guid>("InstalationId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Id на инсталация");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Поле указващо дали записът е изтрит");

                    b.HasKey("UserId", "InstalationId");

                    b.HasIndex("InstalationId");

                    b.ToTable("ApplicationUserPlantInstalations");

                    b.HasComment("Свързваща таблица между потребителите и инсталациите");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.PlantInstalation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Идентификационен ключ");

                    b.Property<Guid>("ComplexId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Id на комплекс");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Пълно наименование на инсталацията");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Съкратено наименование на инсталацията");

                    b.HasKey("Id");

                    b.HasIndex("ComplexId");

                    b.ToTable("PlantInstalations");

                    b.HasComment("Модел на инсталациите");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.ProductionComplex", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Идентификационен ключ");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Пълно наименование на комплекса");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Съкратено наименование на комплекса");

                    b.HasKey("Id");

                    b.ToTable("ProductionComplexes");

                    b.HasComment("Модел на производствените комплекси");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.TechnologicalPosition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Идентификационен ключ");

                    b.Property<Guid>("InstalationId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Id на инсталация");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Наименование на технологичната позиция");

                    b.HasKey("Id");

                    b.HasIndex("InstalationId");

                    b.ToTable("TechnologicalPositions");

                    b.HasComment("Модел на технологична позиция");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.SafeAssignmentDocumentModels.SafeAssignmentDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Идентификационен ключ");

                    b.Property<DateTime?>("ClosingDate")
                        .HasColumnType("datetime2")
                        .HasComment("Дата и час на закриване на наряда");

                    b.Property<string>("ElectricianAppliedVoltageId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Id на потребител подал напрежение");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Състояние на наряда");

                    b.Property<bool>("IsAppliedVoltage")
                        .HasColumnType("bit")
                        .HasComment("Състояние на технологичната позиция");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Номер на наряд според вътрешнонарядната номерация");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2")
                        .HasComment("Дата и час на откриване на наряда");

                    b.Property<string>("PersonRequestedOpeningOrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Id на потребител, поискал откриване на наряда");

                    b.Property<string>("PersonRequestedVoltageSupplyId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Id на потребител поискал подаване на напрежение");

                    b.Property<Guid>("TechnologicalPositionId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Id на технологична позиция");

                    b.Property<string>("ЕlectricianClosingOrderId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Id на потребител закрил наряда");

                    b.Property<string>("ЕlectricianOpeningOrderId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Id на потребител открил наряда");

                    b.HasKey("Id");

                    b.HasIndex("ElectricianAppliedVoltageId");

                    b.HasIndex("PersonRequestedOpeningOrderId");

                    b.HasIndex("PersonRequestedVoltageSupplyId");

                    b.HasIndex("TechnologicalPositionId");

                    b.HasIndex("ЕlectricianClosingOrderId");

                    b.HasIndex("ЕlectricianOpeningOrderId");

                    b.ToTable("SafeAssignmentDocument");

                    b.HasComment("Модел на нарядите");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.StaffsModels.ChangedSchedule", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasComment("Дата");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Id на потребител който е на смяна(оператор или дежурен електромонтьор)");

                    b.Property<Guid>("ShiftId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Id на смяна");

                    b.HasKey("Date", "ApplicationUserId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ShiftId");

                    b.ToTable("ChangedsSchedules");

                    b.HasComment("Модел на сменния график");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.StaffsModels.WorkingShift", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Идентификационен ключ");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2")
                        .HasComment("Краен час на смяната");

                    b.Property<string>("ShiftName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Име на смяната");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2")
                        .HasComment("Начален час на смяната");

                    b.HasKey("Id");

                    b.ToTable("WorkingShifts");

                    b.HasComment("Модел на смените");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUserPlantInstalation", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.FactoryModels.PlantInstalation", "Instalation")
                        .WithMany("ApplicationUserPlantInstalations")
                        .HasForeignKey("InstalationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserPlantInstalations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Instalation");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.PlantInstalation", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.FactoryModels.ProductionComplex", "Complex")
                        .WithMany("PlantInstalations")
                        .HasForeignKey("ComplexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Complex");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.TechnologicalPosition", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.FactoryModels.PlantInstalation", "Instalation")
                        .WithMany("TechnologicalPositions")
                        .HasForeignKey("InstalationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instalation");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.SafeAssignmentDocumentModels.SafeAssignmentDocument", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", "ElectricianAppliedVoltage")
                        .WithMany("ElectriciansAppliedsVoltage")
                        .HasForeignKey("ElectricianAppliedVoltageId");

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", "PersonRequestedOpeningOrder")
                        .WithMany("PersonsRequestedsOpeningOrders")
                        .HasForeignKey("PersonRequestedOpeningOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", "PersonRequestedVoltageSupply")
                        .WithMany("PersonsRequestedsVoltageSupply")
                        .HasForeignKey("PersonRequestedVoltageSupplyId");

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.FactoryModels.TechnologicalPosition", "TechnologicalPosition")
                        .WithMany("SafeAssignmentDocuments")
                        .HasForeignKey("TechnologicalPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", "ЕlectricianClosingOrder")
                        .WithMany("ЕlectriciansClosingOrders")
                        .HasForeignKey("ЕlectricianClosingOrderId");

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", "ЕlectricianOpeningOrder")
                        .WithMany("ЕlectriciansOpeningOrders")
                        .HasForeignKey("ЕlectricianOpeningOrderId");

                    b.Navigation("ElectricianAppliedVoltage");

                    b.Navigation("PersonRequestedOpeningOrder");

                    b.Navigation("PersonRequestedVoltageSupply");

                    b.Navigation("TechnologicalPosition");

                    b.Navigation("ЕlectricianClosingOrder");

                    b.Navigation("ЕlectricianOpeningOrder");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.StaffsModels.ChangedSchedule", b =>
                {
                    b.HasOne("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", "ApplicationUser")
                        .WithMany("ChangedsSchedules")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafeAssignmentSystem.DataBase.Data.StaffsModels.WorkingShift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.Account.ApplicationUser", b =>
                {
                    b.Navigation("ApplicationUserPlantInstalations");

                    b.Navigation("ChangedsSchedules");

                    b.Navigation("ElectriciansAppliedsVoltage");

                    b.Navigation("PersonsRequestedsOpeningOrders");

                    b.Navigation("PersonsRequestedsVoltageSupply");

                    b.Navigation("ЕlectriciansClosingOrders");

                    b.Navigation("ЕlectriciansOpeningOrders");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.PlantInstalation", b =>
                {
                    b.Navigation("ApplicationUserPlantInstalations");

                    b.Navigation("TechnologicalPositions");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.ProductionComplex", b =>
                {
                    b.Navigation("PlantInstalations");
                });

            modelBuilder.Entity("SafeAssignmentSystem.DataBase.Data.FactoryModels.TechnologicalPosition", b =>
                {
                    b.Navigation("SafeAssignmentDocuments");
                });
#pragma warning restore 612, 618
        }
    }
}
