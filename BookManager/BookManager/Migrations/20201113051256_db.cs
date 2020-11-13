using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManager.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "Khoa Học - Kỹ Thuật" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 2, "Lịch Sử - Chính Trị" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 3, "Văn Học Việt Nam" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Count", "Description", "Name", "Year" },
                values: new object[] { 1, "Nick Arnold - Tony De Saulles", 1, 100, "Cuốn sách thuộc bộ Horrible Science, được trình bày bằng giọng văn và các minh họa hài hước quen thuộc của hai tác giả Nick Arnold và Tony De Saulles giúp bạn dễ dàng làm quen với kiến thức cơ bản nhất liên quan đến các loại vi khuẩn vi sinh.", "Horrible Science - Vi Sinh Vật Vi Tính", 2015 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Count", "Description", "Name", "Year" },
                values: new object[] { 2, "William J. Bernstein", 2, 200, "Toàn cầu hóa” hóa ra không phải là một hay thậm chí là một chuỗi sự kiện; mà đó là tiến trình diễn ra chậm rãi trong một thời gian rất, rất dài. Thế giới không đột nhiên trở nên “phẳng” với phát kiến về Internet, và thương mại không bất ngờ bị các tập đoàn lớn tầm cỡ toàn cầu chi phối vào cuối thế kỷ 20. ", "Lịch Sử Giao Thương: Thương Mại Định Hình Thế Giới Như Thế Nào?", 2016 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Count", "Description", "Name", "Year" },
                values: new object[] { 3, "Lan Khai", 3, 250, "Tiểu thuyết chủ đề lịch sử của nhà văn Lan Khai được xuất bản vào năm 1937. Ông được đánh giá là một cây bút sung mãn, một nhà văn đường rừng sáng giá. Dù ở thể loại nào ngòi bút của ông vẫn thuyết phục được cảm tình và lí tính của độc giả.", "Chiếc Ngai Vàng", 2018 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
