using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PeopleService.Migrations
{
    public partial class remove_test_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Another",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "AnotherOne",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "FavoritePet",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ThirdTimeAround",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "WhatEver",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Persons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Another",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnotherOne",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoritePet",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdTimeAround",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatEver",
                table: "Persons",
                nullable: true);
        }
    }
}
