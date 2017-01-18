using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace People.Service.Migrations
{
    public partial class AddContactOwnerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_OwnerId",
                table: "Contacts",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_OwnerId",
                table: "Contacts",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_OwnerId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_OwnerId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Contacts");
        }
    }
}
