using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPWebAngular.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    MaKh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKh = table.Column<string>(type: "varchar(150)", nullable: false),
                    Diachi = table.Column<string>(type: "varchar(200)", nullable: false),
                    Sodienthoai = table.Column<string>(type: "varchar(12)", nullable: false),
                    LoaiKH = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.MaKh);
                });

            migrationBuilder.CreateTable(
                name: "Manufactures",
                columns: table => new
                {
                    MaNCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNCC = table.Column<string>(type: "varchar(150)", nullable: false),
                    Diachi = table.Column<string>(type: "varchar(150)", nullable: false),
                    Sodienthoai = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufactures", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "varchar(200)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    NhaCC = table.Column<string>(type: "varchar(150)", nullable: false),
                    NgayNhanHang = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.MaSP);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Manufactures");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
