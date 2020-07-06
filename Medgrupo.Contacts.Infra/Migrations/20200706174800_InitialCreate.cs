using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medgrupo.Contacts.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 160, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Birth = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Age", "Birth", "CreateDate", "Gender", "LastUpdateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1105d51c-0a7c-4b7c-9ba8-74d281225ee5"), 36, new DateTime(1984, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 6, 14, 48, 0, 270, DateTimeKind.Local).AddTicks(1866), "Masculino", new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5248), "Leonardo" },
                    { new Guid("0c64891e-fe36-4394-9e1d-e2b8ad075c2d"), 5, new DateTime(2015, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5646), "Masculino", new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5754), "Arthur" },
                    { new Guid("232947ae-717b-4ae6-8e29-40af4e6f455a"), 66, new DateTime(1954, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5764), "Feminino", new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5773), "Aidenir" },
                    { new Guid("c2652a8b-628d-4d13-a767-03058f7e7c21"), 26, new DateTime(1994, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5778), "Feminino", new DateTime(2020, 7, 6, 14, 48, 0, 277, DateTimeKind.Local).AddTicks(5784), "Ana Paula" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
