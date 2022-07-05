using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementSysAPI.Migrations
{
    public partial class BookAssToMember_Model_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Member_MemberId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_MemberId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Book");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIssue",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReturn",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "BookAssToMembers",
                columns: table => new
                {
                    BomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAssToMembers", x => x.BomId);
                    table.ForeignKey(
                        name: "FK_BookAssToMembers_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAssToMembers_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookMember",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    MembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookMember", x => new { x.BooksBookId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_BookMember_Book_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookMember_Member_MembersId",
                        column: x => x.MembersId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAssToMembers_BookId",
                table: "BookAssToMembers",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAssToMembers_MemberId",
                table: "BookAssToMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BookMember_MembersId",
                table: "BookMember",
                column: "MembersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAssToMembers");

            migrationBuilder.DropTable(
                name: "BookMember");

            migrationBuilder.DropColumn(
                name: "DateIssue",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "DateReturn",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_MemberId",
                table: "Book",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Member_MemberId",
                table: "Book",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
