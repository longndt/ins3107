using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWeb.Data.Migrations
{
    public partial class seeddatatodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Laptop cho game thủ", "Laptop gaming" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Laptop cho dân văn phòng", "Laptop office" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Laptop cho dân thiết kế", "Laptop design" });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 1, 1, "https://cdn2.cellphones.com.vn/insecure/rs:fill:358:358/q:90/plain/https://cellphones.com.vn/media/catalog/product/g/r/group_509_2__1.png", "ASUS TUF Gaming", 1234.54, 10 });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 2, 2, "https://nhatminhlaptop.com/upload/products/93801-2023-07-21-21-08-50.jpg", "Dell XPS 13", 12356.540000000001, 15 });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 3, 3, "https://cdn2.fptshop.com.vn/unsafe/750x0/filters:quality(100)/2024_2_15_638435927047171103_lenovo-gaming-loq-15iax-9-i5-12450hx-led-trang-1.jpg", "Lenovo LoQ", 1111.51, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
