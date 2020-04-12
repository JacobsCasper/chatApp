using Microsoft.EntityFrameworkCore.Migrations;

namespace chatApp.Migrations
{
    public partial class seedDBWithUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "75f469d9-79e5-4700-b62a-be7957b87cd4", 0, "e7cf8f8a-2fc0-4ecc-96ab-915c706e3573", "AppUser", "Alice@gmail.com", true, false, null, "ALICE@GMAIL.COM", "ALICE@GMAIL.COM", "AQAAAAEAACcQAAAAEKTfaE2A8ArlEZZ6xEvvLmFuJmrH2KnKT4x/vddQUpB+nVlOodI0b8O/0plHhyVBow==", null, false, "cc5d0392-6215-43a0-8539-20af0a4904dc", false, "Alice@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "11133717-b418-4882-b07f-0258e427bd40", 0, "48102f15-16fe-424f-9c7b-95348f45eb55", "AppUser", "Bob@gmail.com", true, false, null, "BOB@GMAIL.COM", "BOB@GMAIL.COM", "AQAAAAEAACcQAAAAEKTfaE2A8ArlEZZ6xEvvLmFuJmrH2KnKT4x/vddQUpB+nVlOodI0b8O/0plHhyVBow==", null, false, "5a27eb55-b3c6-4278-83f0-af4b60072716", false, "Bob@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11133717-b418-4882-b07f-0258e427bd40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75f469d9-79e5-4700-b62a-be7957b87cd4");
        }
    }
}
