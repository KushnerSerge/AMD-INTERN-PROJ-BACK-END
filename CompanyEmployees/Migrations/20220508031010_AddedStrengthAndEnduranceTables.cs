using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class AddedStrengthAndEnduranceTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_AspNetUsers_UserId",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abca5cc6-d3a7-494f-b124-15c3a921dd07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf36c5e-a5f9-4f7b-8504-96e09966e49f");

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

            migrationBuilder.CreateTable(
                name: "Endurance",
                columns: table => new
                {
                    EnduranceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endurance", x => x.EnduranceId);
                    table.ForeignKey(
                        name: "FK_Endurance_Workout_EnduranceId",
                        column: x => x.EnduranceId,
                        principalTable: "Workout",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Strength",
                columns: table => new
                {
                    StrengthId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reps = table.Column<int>(type: "int", nullable: false),
                    sets = table.Column<int>(type: "int", nullable: false),
                    weight = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strength", x => x.StrengthId);
                    table.ForeignKey(
                        name: "FK_Strength_Workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workout",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "373e0025-4142-4501-bd2f-c3d118965b51", "c6afacf6-3f7f-4c20-8769-24ed254e3f85", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abbcf690-b61f-4c3e-89f8-67712aec02ef", "be23abc9-ebcf-4e66-85a0-2df5ce4e4529", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Strength_WorkoutId",
                table: "Strength",
                column: "WorkoutId",
                unique: true,
                filter: "[WorkoutId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_AspNetUsers_UserId",
                table: "Workout",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workout_AspNetUsers_UserId",
                table: "Workout");

            migrationBuilder.DropTable(
                name: "Endurance");

            migrationBuilder.DropTable(
                name: "Strength");

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
                values: new object[] { "abca5cc6-d3a7-494f-b124-15c3a921dd07", "38abf8c2-1263-4d8c-a2cd-556e084918ed", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daf36c5e-a5f9-4f7b-8504-96e09966e49f", "ee94389f-c804-40b3-bef7-5008b5fbd69e", "Manager", "MANAGER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_AspNetUsers_UserId",
                table: "Workouts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
