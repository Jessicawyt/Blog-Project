using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_blog.Migrations
{
    public partial class updatedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://t3.ftcdn.net/jpg/02/55/78/48/240_F_255784802_L7SQkRPUwJWAo9tzmvTyR2Gw1zHuGIBR.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://as1.ftcdn.net/v2/jpg/04/80/37/96/1000_F_480379680_V4zJPsy4mwIZbvpm12sxwC8mT2QDTiMZ.jpg");
        }
    }
}
