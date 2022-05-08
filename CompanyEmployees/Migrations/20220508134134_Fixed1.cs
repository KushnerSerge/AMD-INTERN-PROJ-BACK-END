using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class Fixed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endurance_Workouts_EnduranceId",
                table: "Endurance");

            migrationBuilder.DropForeignKey(
                name: "FK_Strength_Workouts_WorkoutId",
                table: "Strength");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Strength",
                table: "Strength");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endurance",
                table: "Endurance");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b630d8e-8113-43dd-abea-b280e0833612");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ca9b72e-93d2-41d5-9812-2cc6f818b33c");

            migrationBuilder.RenameTable(
                name: "Strength",
                newName: "Strengths");

            migrationBuilder.RenameTable(
                name: "Endurance",
                newName: "Endurances");

            migrationBuilder.RenameIndex(
                name: "IX_Strength_WorkoutId",
                table: "Strengths",
                newName: "IX_Strengths_WorkoutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Strengths",
                table: "Strengths",
                column: "StrengthId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endurances",
                table: "Endurances",
                column: "EnduranceId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Strengths_Workouts_WorkoutId",
                table: "Strengths",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endurances_Workouts_EnduranceId",
                table: "Endurances");

            migrationBuilder.DropForeignKey(
                name: "FK_Strengths_Workouts_WorkoutId",
                table: "Strengths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Strengths",
                table: "Strengths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endurances",
                table: "Endurances");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2383c32f-1b11-4a70-90ee-ab72d5044275");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef0b21c6-c6fa-4f29-abc6-3a5aed318c84");

            migrationBuilder.RenameTable(
                name: "Strengths",
                newName: "Strength");

            migrationBuilder.RenameTable(
                name: "Endurances",
                newName: "Endurance");

            migrationBuilder.RenameIndex(
                name: "IX_Strengths_WorkoutId",
                table: "Strength",
                newName: "IX_Strength_WorkoutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Strength",
                table: "Strength",
                column: "StrengthId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endurance",
                table: "Endurance",
                column: "EnduranceId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b630d8e-8113-43dd-abea-b280e0833612", "f93d78cb-81b0-4e3b-be8e-8f05685058b9", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ca9b72e-93d2-41d5-9812-2cc6f818b33c", "4cbb79c0-497a-49d5-b740-f276154b4597", "Manager", "MANAGER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Endurance_Workouts_EnduranceId",
                table: "Endurance",
                column: "EnduranceId",
                principalTable: "Workouts",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Strength_Workouts_WorkoutId",
                table: "Strength",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
