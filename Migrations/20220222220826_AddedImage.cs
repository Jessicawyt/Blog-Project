using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_blog.Migrations
{
    public partial class AddedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://as1.ftcdn.net/v2/jpg/04/80/37/96/1000_F_480379680_V4zJPsy4mwIZbvpm12sxwC8mT2QDTiMZ.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://t4.ftcdn.net/jpg/00/79/28/35/240_F_79283521_5vAKALj3VP63DmNHdLtJuvOe9R5FnVSi.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://t4.ftcdn.net/jpg/00/13/13/57/240_F_13135712_7oZ432OWueryEad4ll4cVRqqTs4QTk5Q.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");
        }
    }
}
