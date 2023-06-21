using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class AddSafeAssignmentDocumentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocument_TechnologicalPositions_TechnologicalPositionId",
                table: "SafeAssignmentDocument");

            migrationBuilder.AlterTable(
                name: "SafeAssignmentDocument",
                comment: "Модел на нарядите");

            migrationBuilder.AlterColumn<Guid>(
                name: "TechnologicalPositionId",
                table: "SafeAssignmentDocument",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "Id на технологична позиция",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SafeAssignmentDocument",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Идентификационен ключ",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosingDate",
                table: "SafeAssignmentDocument",
                type: "datetime2",
                nullable: true,
                comment: "Дата и час на закриване на наряда");

            migrationBuilder.AddColumn<string>(
                name: "ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocument",
                type: "nvarchar(450)",
                nullable: true,
                comment: "Id на потребител подал напрежение");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SafeAssignmentDocument",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Състояние на наряда");

            migrationBuilder.AddColumn<bool>(
                name: "IsAppliedVoltage",
                table: "SafeAssignmentDocument",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Състояние на технологичната позиция");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "SafeAssignmentDocument",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                comment: "Номер на наряд според вътрешнонарядната номерация");

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningDate",
                table: "SafeAssignmentDocument",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Дата и час на откриване на наряда");

            migrationBuilder.AddColumn<string>(
                name: "PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocument",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Id на потребител, поискал откриване на наряда");

            migrationBuilder.AddColumn<string>(
                name: "PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocument",
                type: "nvarchar(450)",
                nullable: true,
                comment: "Id на потребител поискал подаване на напрежение");

            migrationBuilder.AddColumn<string>(
                name: "ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocument",
                type: "nvarchar(450)",
                nullable: true,
                comment: "Id на потребител закрил наряда");

            migrationBuilder.AddColumn<string>(
                name: "ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocument",
                type: "nvarchar(450)",
                nullable: true,
                comment: "Id на потребител открил наряда");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ApplicationUserPlantInstalations",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Поле указващо дали записът е изтрит");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocument_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocument",
                column: "ЕlectricianClosingOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocument_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocument",
                column: "ЕlectricianOpeningOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocument_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocument",
                column: "ElectricianAppliedVoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocument_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocument",
                column: "PersonRequestedOpeningOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeAssignmentDocument_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocument",
                column: "PersonRequestedVoltageSupplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocument",
                column: "ЕlectricianClosingOrderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocument",
                column: "ЕlectricianOpeningOrderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocument",
                column: "ElectricianAppliedVoltageId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocument",
                column: "PersonRequestedOpeningOrderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocument",
                column: "PersonRequestedVoltageSupplyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocument_TechnologicalPositions_TechnologicalPositionId",
                table: "SafeAssignmentDocument",
                column: "TechnologicalPositionId",
                principalTable: "TechnologicalPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocument_AspNetUsers_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocument_TechnologicalPositions_TechnologicalPositionId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropIndex(
                name: "IX_SafeAssignmentDocument_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropIndex(
                name: "IX_SafeAssignmentDocument_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropIndex(
                name: "IX_SafeAssignmentDocument_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropIndex(
                name: "IX_SafeAssignmentDocument_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropIndex(
                name: "IX_SafeAssignmentDocument_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "ClosingDate",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "IsAppliedVoltage",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "OpeningDate",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocument");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ApplicationUserPlantInstalations");

            migrationBuilder.AlterTable(
                name: "SafeAssignmentDocument",
                oldComment: "Модел на нарядите");

            migrationBuilder.AlterColumn<Guid>(
                name: "TechnologicalPositionId",
                table: "SafeAssignmentDocument",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Id на технологична позиция");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SafeAssignmentDocument",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Идентификационен ключ");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocument_TechnologicalPositions_TechnologicalPositionId",
                table: "SafeAssignmentDocument",
                column: "TechnologicalPositionId",
                principalTable: "TechnologicalPositions",
                principalColumn: "Id");
        }
    }
}
