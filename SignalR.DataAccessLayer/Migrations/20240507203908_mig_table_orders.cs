using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class mig_table_orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "TableDetailID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableDetailID",
                table: "Orders",
                column: "TableDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TableDetails_TableDetailID",
                table: "Orders",
                column: "TableDetailID",
                principalTable: "TableDetails",
                principalColumn: "TableDetailID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TableDetails_TableDetailID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableDetailID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TableDetailID",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "TableNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
