using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.Migrations
{
    public partial class InitCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "ActivityTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTemplates_CategoryId",
                table: "ActivityTemplates",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTemplates_userId",
                table: "ActivityTemplates",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ActivityTemplateId",
                table: "Activities",
                column: "ActivityTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_userId",
                table: "Activities",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_ActivityTemplates_ActivityTemplateId",
                table: "Activities",
                column: "ActivityTemplateId",
                principalTable: "ActivityTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_userId",
                table: "Activities",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityTemplates_Categories_CategoryId",
                table: "ActivityTemplates",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityTemplates_Users_userId",
                table: "ActivityTemplates",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_ActivityTemplates_ActivityTemplateId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_userId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_ActivityTemplates_Categories_CategoryId",
                table: "ActivityTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_ActivityTemplates_Users_userId",
                table: "ActivityTemplates");

            migrationBuilder.DropIndex(
                name: "IX_ActivityTemplates_CategoryId",
                table: "ActivityTemplates");

            migrationBuilder.DropIndex(
                name: "IX_ActivityTemplates_userId",
                table: "ActivityTemplates");

            migrationBuilder.DropIndex(
                name: "IX_Activities_ActivityTemplateId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_userId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "ActivityTemplates");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Activities");
        }
    }
}
