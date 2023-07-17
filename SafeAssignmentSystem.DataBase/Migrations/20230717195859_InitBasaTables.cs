using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class InitBasaTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                },
                comment: "Модел на ролите");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Собствено име на потребител"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Фамилно име на потребител"),
                    UserWorkNumber = table.Column<int>(type: "int", nullable: false, comment: "Табелен номер на потребителя"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                },
                comment: "Модел на потребителите");

            migrationBuilder.CreateTable(
                name: "ProductionComplexes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Идентификационен ключ"),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Пълно наименование на комплекса"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Съкратено наименование на комплекса"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Указател, показващ дали модела на комплекса е изтрит")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionComplexes", x => x.Id);
                },
                comment: "Модел на производствените комплекси");

            migrationBuilder.CreateTable(
                name: "WorkingShifts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Идентификационен ключ"),
                    ShiftName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Име на смяната"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Начален час на смяната"),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Краен час на смяната")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingShifts", x => x.Id);
                },
                comment: "Модел на смените");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantInstalations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Идентификационен ключ"),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Пълно наименование на инсталацията"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Съкратено наименование на инсталацията"),
                    ComplexId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на комплекс")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantInstalations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantInstalations_ProductionComplexes_ComplexId",
                        column: x => x.ComplexId,
                        principalTable: "ProductionComplexes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Модел на инсталациите");

            migrationBuilder.CreateTable(
                name: "ChangedsSchedules",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Дата"),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на потребител който е на смяна(оператор или дежурен електромонтьор)"),
                    ShiftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на смяна")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangedsSchedules", x => new { x.Date, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_ChangedsSchedules_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChangedsSchedules_WorkingShifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "WorkingShifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Модел на сменния график");

            migrationBuilder.CreateTable(
                name: "ApplicationUserPlantInstalations",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на потребител"),
                    InstalationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на инсталация"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Поле указващо дали записът е изтрит")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserPlantInstalations", x => new { x.UserId, x.InstalationId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserPlantInstalations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserPlantInstalations_PlantInstalations_InstalationId",
                        column: x => x.InstalationId,
                        principalTable: "PlantInstalations",
                        principalColumn: "Id");
                },
                comment: "Свързваща таблица между потребителите и инсталациите");

            migrationBuilder.CreateTable(
                name: "TechnologicalPositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Идентификационен ключ"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Наименование на технологичната позиция"),
                    InstalationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на инсталация")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnologicalPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnologicalPositions_PlantInstalations_InstalationId",
                        column: x => x.InstalationId,
                        principalTable: "PlantInstalations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Модел на технологична позиция");

            migrationBuilder.CreateTable(
                name: "SafeAssignmentDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Идентификационен ключ"),
                    Number = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Номер на наряд според вътрешнонарядната номерация"),
                    TechnologicalPositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на технологична позиция"),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Дата и час на откриване на наряда"),
                    PersonRequestedOpeningOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Id на потребител, поискал откриване на наряда"),
                    ЕlectricianOpeningOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "Id на потребител открил наряда"),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Дата и час на закриване на наряда"),
                    ЕlectricianClosingOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "Id на потребител закрил наряда"),
                    PersonRequestedVoltageSupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "Id на потребител поискал подаване на напрежение"),
                    ElectricianAppliedVoltageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "Id на потребител подал напрежение"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Статус на наряда")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafeAssignmentDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SafeAssignmentDocuments_AspNetUsers_ЕlectricianClosingOrderId",
                        column: x => x.ЕlectricianClosingOrderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SafeAssignmentDocuments_AspNetUsers_ЕlectricianOpeningOrderId",
                        column: x => x.ЕlectricianOpeningOrderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SafeAssignmentDocuments_AspNetUsers_ElectricianAppliedVoltageId",
                        column: x => x.ElectricianAppliedVoltageId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SafeAssignmentDocuments_AspNetUsers_PersonRequestedOpeningOrderId",
                        column: x => x.PersonRequestedOpeningOrderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SafeAssignmentDocuments_AspNetUsers_PersonRequestedVoltageSupplyId",
                        column: x => x.PersonRequestedVoltageSupplyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SafeAssignmentDocuments_TechnologicalPositions_TechnologicalPositionId",
                        column: x => x.TechnologicalPositionId,
                        principalTable: "TechnologicalPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Модел на нарядите");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPlantInstalations_InstalationId",
                table: "ApplicationUserPlantInstalations",
                column: "InstalationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChangedsSchedules_ApplicationUserId",
                table: "ChangedsSchedules",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangedsSchedules_ShiftId",
                table: "ChangedsSchedules",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantInstalations_ComplexId",
                table: "PlantInstalations",
                column: "ComplexId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocuments_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocuments",
                column: "ЕlectricianClosingOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocuments_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocuments",
                column: "ЕlectricianOpeningOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocuments_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocuments",
                column: "ElectricianAppliedVoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocuments_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocuments",
                column: "PersonRequestedOpeningOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocuments_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocuments",
                column: "PersonRequestedVoltageSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocuments_TechnologicalPositionId",
                table: "SafeAssignmentDocuments",
                column: "TechnologicalPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnologicalPositions_InstalationId",
                table: "TechnologicalPositions",
                column: "InstalationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserPlantInstalations");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChangedsSchedules");

            migrationBuilder.DropTable(
                name: "SafeAssignmentDocuments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "WorkingShifts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TechnologicalPositions");

            migrationBuilder.DropTable(
                name: "PlantInstalations");

            migrationBuilder.DropTable(
                name: "ProductionComplexes");
        }
    }
}
