using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rel2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Deptno = table.Column<int>(type: "int", nullable: false),
                    Deptname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Deptno);
                });

            migrationBuilder.CreateTable(
                name: "EmpDetails_1",
                columns: table => new
                {
                    empno = table.Column<int>(type: "int", nullable: false),
                    aadharno = table.Column<long>(type: "bigint", nullable: false),
                    panno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpDetails_1", x => x.empno);
                });

            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    Empno = table.Column<int>(type: "int", nullable: false),
                    Empname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deptno = table.Column<int>(type: "int", nullable: true),
                    DeptnoRefDeptno = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.Empno);
                    table.ForeignKey(
                        name: "FK_Emp_Depts_DeptnoRefDeptno",
                        column: x => x.DeptnoRefDeptno,
                        principalTable: "Depts",
                        principalColumn: "Deptno");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emp_DeptnoRefDeptno",
                table: "Emp",
                column: "DeptnoRefDeptno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emp");

            migrationBuilder.DropTable(
                name: "EmpDetails_1");

            migrationBuilder.DropTable(
                name: "Depts");
        }
    }
}
