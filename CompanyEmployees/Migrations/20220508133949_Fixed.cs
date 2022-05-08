using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endurance_Workout_EnduranceId",
                table: "Endurance");

            migrationBuilder.DropForeignKey(
                name: "FK_Strength_Workout_WorkoutId",
                table: "Strength");

            migrationBuilder.DropForeignKey(
                name: "FK_Workout_AspNetUsers_UserId",
                table: "Workout");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workout",
                table: "Workout");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "373e0025-4142-4501-bd2f-c3d118965b51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abbcf690-b61f-4c3e-89f8-67712aec02ef");

            migrationBuilder.RenameTable(
                name: "Workout",
                newName: "Workouts");

            migrationBuilder.RenameIndex(
                name: "IX_Workout_UserId",
                table: "Workouts",
                newName: "IX_Workouts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts",
                column: "WorkoutId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_AspNetUsers_UserId",
                table: "Workouts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endurance_Workouts_EnduranceId",
                table: "Endurance");

            migrationBuilder.DropForeignKey(
                name: "FK_Strength_Workouts_WorkoutId",
                table: "Strength");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_AspNetUsers_UserId",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b630d8e-8113-43dd-abea-b280e0833612");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ca9b72e-93d2-41d5-9812-2cc6f818b33c");

            migrationBuilder.RenameTable(
                name: "Workouts",
                newName: "Workout");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_UserId",
                table: "Workout",
                newName: "IX_Workout_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workout",
                table: "Workout",
                column: "WorkoutId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "373e0025-4142-4501-bd2f-c3d118965b51", "c6afacf6-3f7f-4c20-8769-24ed254e3f85", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abbcf690-b61f-4c3e-89f8-67712aec02ef", "be23abc9-ebcf-4e66-85a0-2df5ce4e4529", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Endurance_Workout_EnduranceId",
                table: "Endurance",
                column: "EnduranceId",
                principalTable: "Workout",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Strength_Workout_WorkoutId",
                table: "Strength",
                column: "WorkoutId",
                principalTable: "Workout",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_AspNetUsers_UserId",
                table: "Workout",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
