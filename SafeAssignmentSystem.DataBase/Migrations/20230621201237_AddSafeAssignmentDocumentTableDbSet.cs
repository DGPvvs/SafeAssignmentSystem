using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class AddSafeAssignmentDocumentTableDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_SafeAssignmentDocument",
                table: "SafeAssignmentDocument");

            migrationBuilder.RenameTable(
                name: "SafeAssignmentDocument",
                newName: "SafeAssignmentDocuments");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocument_TechnologicalPositionId",
                table: "SafeAssignmentDocuments",
                newName: "IX_SafeAssignmentDocuments_TechnologicalPositionId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocument_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocuments",
                newName: "IX_SafeAssignmentDocuments_PersonRequestedVoltageSupplyId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocument_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocuments",
                newName: "IX_SafeAssignmentDocuments_PersonRequestedOpeningOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocument_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocuments",
                newName: "IX_SafeAssignmentDocuments_ElectricianAppliedVoltageId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocument_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocuments",
                newName: "IX_SafeAssignmentDocuments_ЕlectricianOpeningOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocument_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocuments",
                newName: "IX_SafeAssignmentDocuments_ЕlectricianClosingOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SafeAssignmentDocuments",
                table: "SafeAssignmentDocuments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocuments",
                column: "ЕlectricianClosingOrderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocuments",
                column: "ЕlectricianOpeningOrderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocuments",
                column: "ElectricianAppliedVoltageId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocuments",
                column: "PersonRequestedOpeningOrderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocuments",
                column: "PersonRequestedVoltageSupplyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SafeAssignmentDocuments_TechnologicalPositions_TechnologicalPositionId",
                table: "SafeAssignmentDocuments",
                column: "TechnologicalPositionId",
                principalTable: "TechnologicalPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocuments_AspNetUsers_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_SafeAssignmentDocuments_TechnologicalPositions_TechnologicalPositionId",
                table: "SafeAssignmentDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SafeAssignmentDocuments",
                table: "SafeAssignmentDocuments");

            migrationBuilder.RenameTable(
                name: "SafeAssignmentDocuments",
                newName: "SafeAssignmentDocument");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocuments_TechnologicalPositionId",
                table: "SafeAssignmentDocument",
                newName: "IX_SafeAssignmentDocument_TechnologicalPositionId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocuments_PersonRequestedVoltageSupplyId",
                table: "SafeAssignmentDocument",
                newName: "IX_SafeAssignmentDocument_PersonRequestedVoltageSupplyId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocuments_PersonRequestedOpeningOrderId",
                table: "SafeAssignmentDocument",
                newName: "IX_SafeAssignmentDocument_PersonRequestedOpeningOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocuments_ElectricianAppliedVoltageId",
                table: "SafeAssignmentDocument",
                newName: "IX_SafeAssignmentDocument_ElectricianAppliedVoltageId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocuments_ЕlectricianOpeningOrderId",
                table: "SafeAssignmentDocument",
                newName: "IX_SafeAssignmentDocument_ЕlectricianOpeningOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SafeAssignmentDocuments_ЕlectricianClosingOrderId",
                table: "SafeAssignmentDocument",
                newName: "IX_SafeAssignmentDocument_ЕlectricianClosingOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SafeAssignmentDocument",
                table: "SafeAssignmentDocument",
                column: "Id");

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
    }
}
