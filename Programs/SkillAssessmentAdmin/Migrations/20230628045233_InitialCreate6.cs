using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillAssessmentAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "TopicName",
                table: "UserRequests");

            migrationBuilder.RenameColumn(
                name: "TimeAlloted",
                table: "UserRequests",
                newName: "TotalTime");

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "UserRequests",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalTime",
                table: "UserAssessments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfSubmission",
                table: "AssessmentHistorys",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "UserAssessments");

            migrationBuilder.RenameColumn(
                name: "TotalTime",
                table: "UserRequests",
                newName: "TimeAlloted");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkillLevel",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TopicName",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfSubmission",
                table: "AssessmentHistorys",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);
        }
    }
}
