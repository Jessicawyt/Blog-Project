using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_blog.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Travel" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Language" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Timothy Dean", "Located just one hour north of Adelaide, the rolling hills of the Barossa Valley will captivate with their seemingly endless spread of Australian wineries. You’ll be impressed with the region’s unique varietals available to taste at exquisite cellar doors. When you’re not indulging in some of the world’s finest wine and food pairings,reside in a luxury hotel,or explore the picturesque cluster of villages,rolling hills,stone churches and vineyards by bike,vintage car,hot air balloon or even a helicopter.", 1, new DateTime(2008, 3, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Complete Guide to hiking in Australia" },
                    { 2, "Jane Levan", "At 115,545 hectares Yok Don National Park is the largest of Vietnam’s natural reserves and is home to wildlife including leopards, red wolves, muntjac deer, monkeys, snakes and wild elephants.The park is located in the Buon Don district in the province of Dak Lak,where the majority of tourist riding camps in Vietnam operate.The park offered elephant rides to tourists for many years, but had started to sense a growing government and community concern for elephant welfare.", 1, new DateTime(2011, 3, 5, 2, 0, 0, 0, DateTimeKind.Unspecified), "Hope on an amazing Elephant Ride in Vietnam" },
                    { 3, "Michelle Choi", "Whether you prefer dancing and dining in the busy night clubs of Seoul or exploring the stunning natural scenery of Jeju Island, South Korea has something for every traveler. The only downside is that there's too much to see and do to pack into a single vacation. Every country has its highlights, however, and there are certain things it's hard to pass by. Don't miss these must-see attractions during your dream vacation to South Korea.", 1, new DateTime(2014, 3, 5, 2, 0, 0, 0, DateTimeKind.Unspecified), "Train to Busan and back" },
                    { 4, "Chuqiao Li", "Also known as Yellow Mountain, Huangshan is one of China’s most popular national parks and a UNESCO World Heritage Site. This mountain range and surrounding scenic areas, often surrounded in mist, is located in southern Anhui Province in Eastern China and is famous for its four wonders: wind-carved pines, a picturesque sea of clouds, granite peaks, and relaxing hot springs. It’s described as one of the most picturesque mountains in China and has long been a draw for artists and writers.Here you'll find hikes that are suitable for beginners with spectacular views that will impress even the most seasoned trekkers. The network of cable cars also makes this an accessible national park for anyone unable to hike who still wants to make the most of their visit.", 1, new DateTime(2015, 6, 5, 2, 0, 13, 0, DateTimeKind.Unspecified), "Discovering HuangShan, among the smog" },
                    { 5, "Ann Blor", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Architecto asperiores repellat delectus hic tempora! Distinctio laborum tempore veritatis? Reiciendis doloremque quos sint explicabo perspiciatis, obcaecati impedit, neque expedita enim nemo cumque earum voluptatibus aliquam, deserunt consectetur inventore molestias esse! Corrupti?", 2, new DateTime(2021, 8, 5, 9, 0, 45, 0, DateTimeKind.Unspecified), "How to Make Spinach Artichoke Dip" },
                    { 6, "Stephanie", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Architecto asperiores repellat delectus hic tempora! Distinctio laborum tempore veritatis? Reiciendis doloremque quos sint explicabo perspiciatis, obcaecati impedit, neque expedita enim nemo cumque earum voluptatibus aliquam, deserunt consectetur inventore molestias esse! Corrupti?", 2, new DateTime(2022, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Secret To Perfect Creamy Roasted Garlic Hummus" },
                    { 7, "Yuting Wang", "中国，一个伟大、独特、充满东方神韵的国度，雄踞于亚洲东部、太平洋西岸。在这块960万平方公里的土地上，汇集了秀丽的自然美景、众多的历史遗迹、丰富多采的文化，13亿勤劳、智慧、好客的人民在这里繁衍生息。中国是世界文明发达最早的国家之一。距今有文字可考 的历史已达四千多年。举世闻名的四大发明----指南针、火药、造纸术、印刷术都是中国人的创造，推动了人类社会发展的进程。在漫长的历史中，中国形成了独特的文化、生活方式、风俗习惯，留下了无数的瑰宝，中国也因此具有独特的魅力。  中国拥有非常丰富的旅游资源。北京、西安、南京、杭州、洛阳、开封、安阳等七大古都收藏的文物瑰宝和艺术珍品不可胜计。中国的园林艺术历史悠久，风格独特。其总体特点是建筑物有规则的形状和山岩树木不规则的强烈对比，达到了多样而统一的艺术效果。中国的山河壮丽，气象万千，有许多引人入胜的自然景观。中国名山首推五岳，即泰山，华山，衡山，恒山和嵩山。中国的书法、绘画，珠联璧合，相映生辉，一些古代真品，往往价值连城。中国书法共分篆书、隶书、草书、楷书、行书等五种书体。中国的笔、墨、纸、砚文房四宝，是中国 的一大珍品。中国的表演艺术丰富多彩，享誉中外。全国的地方戏曲剧种360余种，尚有杂技、曲艺、皮影、木偶戏、民族乐器演奏和民族歌舞等具有各种不同风格的艺术表演形式。中国是一个多民族的国家，拥有汉、满、蒙古、回、维吾尔、壮、藏等56个民族，分布在全国各地。由于自然条件和社会环境的不同，逐渐形成了不同的风俗民情。  中国的烹调技艺是中国古老文化的一个组成部分，风格独特，名闻海外。经过长期的实践，逐渐形成了山东、淮扬、四川、广东四大菜系。此外，还有各种地方的风味，名菜佳肴。全国共有1万余种名菜。", 3, new DateTime(2021, 3, 5, 2, 10, 22, 0, DateTimeKind.Unspecified), "Chinese Notebook" },
                    { 8, "Kim Choi", "모든 사람은 교육을 받을 권리를 가진다 . 교육은 최소한 초등 및 기초단계에서는 무상이어야 한다. 초등교육은 의무적이어야 한다. 기술 및 직업교육은 일반적으로 접근이 가능하여야 하며, 고등교육은 모든 사람에게 실력에 근거하여 동등하게 접근 가능하여야 한다.교육은 인격의 완전한 발전과 인권과 기본적 자유에 대한 존중의 강화를 목표로 한다. 교육은 모든 국가 , 인종 또는 종교 집단간에 이해, 관용 및 우의를 증진하며, 평화의 유지를 위한 국제연합의 활동을 촉진하여야 한다.부모는 자녀에게 제공되는 교육의 종류를 선택할 우선권을 가진다 .제 27 조모든 사람은 공동체의 문화생활에 자유롭게 참여하며 예술을 향유하고 과학의 발전과 그 혜택을 공유할 권리를 가진다.모든 사람은 자신이 창작한 과학적 , 문학적 또는 예술적 산물로부터 발생하는 정신적, 물질적 이익을 보호받을 권리를 가진다 .", 3, new DateTime(2021, 5, 2, 2, 5, 0, 0, DateTimeKind.Unspecified), "Korean Notebook" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
