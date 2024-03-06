using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreateDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor.\r\nSmještena u mirnom okruženju, samo 50 metara od plaže.\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n", "", "King vila", 5, 2000.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor.\r\nSmještena u mirnom okruženju, samo 50 metara od plaže.\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n", "", "King vila 2", 5, 1000.0, 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor.\r\nSmještena u mirnom okruženju, samo 50 metara od plaže.\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n", "", "King vila 3", 4, 1200.0, 350, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor.\r\nSmještena u mirnom okruženju, samo 50 metara od plaže.\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n", "", "King vila 4", 3, 800.0, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor.\r\nSmještena u mirnom okruženju, samo 50 metara od plaže.\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n", "", "King vila 5", 5, 1400.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor.\r\nSmještena u mirnom okruženju, samo 50 metara od plaže.\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n", "", "King vila 6", 5, 1000.0, 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
