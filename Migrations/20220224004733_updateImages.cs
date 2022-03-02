using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_blog.Migrations
{
    public partial class updateImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.lifeofpix.com/wp-content/uploads/2018/07/lake-antholz-late-autumn-1600x1067.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://cdn.vox-cdn.com/thumbor/9qN-DmdwZE__GqwuoJIinjUXzmk=/0x0:960x646/1200x900/filters:focal(404x247:556x399)/cdn.vox-cdn.com/uploads/chorus_image/image/63084260/foodlife_2.0.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://thehill.com/sites/default/files/ca_thankyou_multilingual_language_istock.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://t3.ftcdn.net/jpg/01/86/35/50/240_F_186355025_QIDaOSxmPb3qZvmHsdr3IgGv3pzGANuR.jpg");

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
    }
}
