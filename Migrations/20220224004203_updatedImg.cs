using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_blog.Migrations
{
    public partial class updatedImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://t3.ftcdn.net/jpg/01/86/35/50/240_F_186355025_QIDaOSxmPb3qZvmHsdr3IgGv3pzGANuR.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://t3.ftcdn.net/jpg/02/55/78/48/240_F_255784802_L7SQkRPUwJWAo9tzmvTyR2Gw1zHuGIBR.jpg");
        }
    }
}
