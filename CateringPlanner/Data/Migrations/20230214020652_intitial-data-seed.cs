using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CateringPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class intitialdataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "Email", "FirstName", "LastName", "PhoneNumber", "State", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 10, "Nowhere", "bob@bobble.com", "Bob", "Blart", "545-555-5454", "Alaska", "123 Nowhere Lane", 1234 },
                    { 11, "Somewhere", "becky@bobble.com", "Becky", "Blazer", "454-555-4545", "Arizona", "123 Somewhere Lane", 43210 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mushrooms" },
                    { 2, "Onions" },
                    { 3, "Marsala Wine" },
                    { 4, "Chicken Stock" },
                    { 5, "Garlic" },
                    { 6, "Parsley(fresh)" },
                    { 7, "Egg Noodles" },
                    { 8, "Broccoli" },
                    { 9, "Flour" },
                    { 10, "Oil Blend" },
                    { 11, "Chicken Tenders" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Name" },
                values: new object[] { 101, "Chicken Marsala" });

            migrationBuilder.InsertData(
                table: "MenuItemIngredients",
                columns: new[] { "IngredientId", "MenuItemId", "Quantity" },
                values: new object[,]
                {
                    { 1, 101, 0 },
                    { 2, 101, 1 },
                    { 3, 101, 1 },
                    { 4, 101, 1 },
                    { 5, 101, 1 },
                    { 6, 101, 1 },
                    { 7, 101, 1 },
                    { 8, 101, 1 },
                    { 9, 101, 1 },
                    { 10, 101, 1 },
                    { 11, 101, 1 }
                });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "Id", "CustomerId", "DateTime", "NumberOfPeople" },
                values: new object[] { 1, 10, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.InsertData(
                table: "PartyMenuItems",
                columns: new[] { "MenuItemId", "PartyId" },
                values: new object[] { 101, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 1, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 2, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 3, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 4, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 5, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 6, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 7, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 8, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 9, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 10, 101 });

            migrationBuilder.DeleteData(
                table: "MenuItemIngredients",
                keyColumns: new[] { "IngredientId", "MenuItemId" },
                keyValues: new object[] { 11, 101 });

            migrationBuilder.DeleteData(
                table: "PartyMenuItems",
                keyColumns: new[] { "MenuItemId", "PartyId" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
