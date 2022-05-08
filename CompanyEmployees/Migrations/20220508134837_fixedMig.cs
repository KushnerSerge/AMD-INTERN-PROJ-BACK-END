using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class fixedMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endurances_Workouts_EnduranceId",
                table: "Endurances");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2383c32f-1b11-4a70-90ee-ab72d5044275");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef0b21c6-c6fa-4f29-abc6-3a5aed318c84");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1dd68adc-45a4-4043-9260-5077552ed6c4", "db5b0513-2738-41cd-8e7f-5e96ce3bd8a6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e6f1540-1fbd-439c-9ec2-01bec469cce3", "df1b755d-b52e-490b-aaae-d83efcc231f2", "Manager", "MANAGER" });

            migrationBuilder.CreateIndex(
                name: "IX_Endurances_WorkoutId",
                table: "Endurances",
                column: "WorkoutId",
                unique: true,
                filter: "[WorkoutId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Endurances_Workouts_WorkoutId",
                table: "Endurances",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endurances_Workouts_WorkoutId",
                table: "Endurances");

            migrationBuilder.DropIndex(
                name: "IX_Endurances_WorkoutId",
                table: "Endurances");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dd68adc-45a4-4043-9260-5077552ed6c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e6f1540-1fbd-439c-9ec2-01bec469cce3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2383c32f-1b11-4a70-90ee-ab72d5044275", "89d437b3-832c-4d8c-bae7-9454af1f8c84", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef0b21c6-c6fa-4f29-abc6-3a5aed318c84", "cb2e2b75-e8aa-452a-b366-379c3d0a2814", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Endurances_Workouts_EnduranceId",
                table: "Endurances",
                column: "EnduranceId",
                principalTable: "Workouts",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
