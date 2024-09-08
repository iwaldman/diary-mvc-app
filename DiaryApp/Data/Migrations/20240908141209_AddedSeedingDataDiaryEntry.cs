using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Lisa.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(4883), "Went Hiking" },
                    { 2, "Walked Henri and Hugo. Both has massive dumps!", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5032), "Walked Dogs" },
                    { 3, "Went to the gym and did some cardio.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5035), "Went to the Gym" },
                    { 4, "Went to the movies and watched a comedy.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5037), "Went to the Movies" },
                    { 5, "Went to the beach and swam in the ocean.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5039), "Went to the Beach" },
                    { 6, "Went to the park and had a picnic.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5040), "Went to the Park" },
                    { 7, "Went to the zoo and saw the animals.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5043), "Went to the Zoo" },
                    { 8, "Went to the museum and saw the exhibits.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5045), "Went to the Museum" },
                    { 9, "Went to the library and read some books.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5046), "Went to the Library" },
                    { 10, "Went to the mall and did some shopping.", new DateTime(2024, 9, 8, 9, 12, 8, 898, DateTimeKind.Local).AddTicks(5048), "Went to the Mall" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
