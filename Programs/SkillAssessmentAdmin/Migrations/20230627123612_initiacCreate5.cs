using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillAssessmentAdmin.Migrations
{
    /// <inheritdoc />
    public partial class initiacCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserRequests",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AssessmentId",
                table: "UserRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRequests_AssessmentId",
                table: "UserRequests",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRequests_UserId",
                table: "UserRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRequests_Assessments_AssessmentId",
                table: "UserRequests",
                column: "AssessmentId",
                principalTable: "Assessments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRequests_Users_UserId",
                table: "UserRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRequests_Assessments_AssessmentId",
                table: "UserRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRequests_Users_UserId",
                table: "UserRequests");

            migrationBuilder.DropIndex(
                name: "IX_UserRequests_AssessmentId",
                table: "UserRequests");

            migrationBuilder.DropIndex(
                name: "IX_UserRequests_UserId",
                table: "UserRequests");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AssessmentId",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
