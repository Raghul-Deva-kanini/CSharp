using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillAssessmentAdmin.Migrations
{
    /// <inheritdoc />
    public partial class initiacCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "DateOfCompletion",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "NumberOfQuestions",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "NumberOfTopics",
                table: "Assessments");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentHistoryId",
                table: "UserAssessments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCompletion",
                table: "UserAssessments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "UserAssessments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserAssessments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfQuestions",
                table: "UserAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTopics",
                table: "UserAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "QuestionPages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionPages_UserId",
                table: "QuestionPages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionPages_Users_UserId",
                table: "QuestionPages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments",
                column: "AssessmentHistoryId",
                principalTable: "AssessmentHistorys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionPages_Users_UserId",
                table: "QuestionPages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments");

            migrationBuilder.DropIndex(
                name: "IX_QuestionPages_UserId",
                table: "QuestionPages");

            migrationBuilder.DropColumn(
                name: "DateOfCompletion",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "NumberOfQuestions",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "NumberOfTopics",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "QuestionPages");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentHistoryId",
                table: "UserAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCompletion",
                table: "Assessments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfQuestions",
                table: "Assessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTopics",
                table: "Assessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments",
                column: "AssessmentHistoryId",
                principalTable: "AssessmentHistorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
