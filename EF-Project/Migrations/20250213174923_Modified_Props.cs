using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class Modified_Props : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lName",
                table: "Users",
                newName: "UlName");

            migrationBuilder.RenameColumn(
                name: "fName",
                table: "Users",
                newName: "UfName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "UPassword");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "UEmail");

            migrationBuilder.RenameColumn(
                name: "Budget",
                table: "Users",
                newName: "UBudget");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Users",
                newName: "UAge");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Expenses",
                newName: "ExpPrice");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Expenses",
                newName: "Expdate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Expenses",
                newName: "ExpName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "CatName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UlName",
                table: "Users",
                newName: "lName");

            migrationBuilder.RenameColumn(
                name: "UfName",
                table: "Users",
                newName: "fName");

            migrationBuilder.RenameColumn(
                name: "UPassword",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "UEmail",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UBudget",
                table: "Users",
                newName: "Budget");

            migrationBuilder.RenameColumn(
                name: "UAge",
                table: "Users",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "UId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ExpPrice",
                table: "Expenses",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Expdate",
                table: "Expenses",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "ExpName",
                table: "Expenses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CatName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CatId",
                table: "Categories",
                newName: "Id");
        }
    }
}
