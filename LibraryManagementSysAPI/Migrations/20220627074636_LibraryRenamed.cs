using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementSysAPI.Migrations
{
    public partial class LibraryRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Libarary_LibraryId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Librarian_Libarary_LibraryID",
                table: "Librarian");

            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Libarary_LibraryID",
                table: "Membership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Libarary",
                table: "Libarary");

            migrationBuilder.RenameTable(
                name: "Libarary",
                newName: "Library");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Library",
                table: "Library",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Library_LibraryId",
                table: "Book",
                column: "LibraryId",
                principalTable: "Library",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Librarian_Library_LibraryID",
                table: "Librarian",
                column: "LibraryID",
                principalTable: "Library",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_Library_LibraryID",
                table: "Membership",
                column: "LibraryID",
                principalTable: "Library",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Library_LibraryId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Librarian_Library_LibraryID",
                table: "Librarian");

            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Library_LibraryID",
                table: "Membership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Library",
                table: "Library");

            migrationBuilder.RenameTable(
                name: "Library",
                newName: "Libarary");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Libarary",
                table: "Libarary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Libarary_LibraryId",
                table: "Book",
                column: "LibraryId",
                principalTable: "Libarary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Librarian_Libarary_LibraryID",
                table: "Librarian",
                column: "LibraryID",
                principalTable: "Libarary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_Libarary_LibraryID",
                table: "Membership",
                column: "LibraryID",
                principalTable: "Libarary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
