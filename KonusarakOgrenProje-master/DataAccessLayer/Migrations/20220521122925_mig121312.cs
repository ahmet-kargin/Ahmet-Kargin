using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig121312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => new { x.SizeId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Elbise" },
                    { 2, "Gömlek" },
                    { 3, "Tişört" },
                    { 4, "Kazak" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "Name" },
                values: new object[,]
                {
                    { 1, "Siyah" },
                    { 2, "Beyaz" },
                    { 3, "Mavi" },
                    { 4, "Kırmızı" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Mail", "Name", "TelNo" },
                values: new object[,]
                {
                    { 1, "lcw@gmail.com", "LCW", "5325486448" },
                    { 2, "koton@gmail.com", "Koton", "5458599754" },
                    { 3, "pull@gmail.com", "Pull&Bear", "5236548964" },
                    { 4, "zara@gmail.com", "Zara", "5214589645" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "SizeName" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "UserName" },
                values: new object[] { 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryId", "ColorId", "CompanyId", "Description", "ImageUrl", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, "Lorem ipsum, dolor sit amet consectetur adipisicing elit.", "1.png", "Ürün1", 700m, true },
                    { 2, 2, 2, 1, "Lorem ipsum, dolor sit amet consectetur adipisicing elit.", "2.png", "Ürün2", 600m, true },
                    { 3, 3, 3, 2, "Lorem ipsum, dolor sit amet consectetur adipisicing elit.", "3.png", "Ürün3", 500m, true },
                    { 4, 4, 1, 2, "Lorem ipsum, dolor sit amet consectetur adipisicing elit.", "4.png", "Ürün4", 400m, true },
                    { 5, 4, 2, 3, "Lorem ipsum, dolor sit amet consectetur adipisicing elit.", "5.png", "Ürün5", 300m, true },
                    { 6, 3, 3, 4, "Lorem ipsum, dolor sit amet consectetur adipisicing elit.", "6.png", "Ürün6", 200m, true },
                    { 7, 2, 1, 3, "Lorem ipsum, dolor sit amet consectetur adipisicing elit.", "7.png", "Ürün7", 100m, true }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentContent", "CommentStatus", "CommentTitle", "CommentUserName", "ProductId" },
                values: new object[,]
                {
                    { 1, "lorem ıpsum", true, "Harika bir Ürün", "Murat Kuşcan", 1 },
                    { 2, "lorem ıpsum", true, "Kötü bir Ürün", "Hakan Derkan", 1 },
                    { 3, "lorem ıpsum", true, "Çok pahalı", "Berkay", 2 },
                    { 4, "lorem ıpsum", true, "ucuz bayıldım", "Ahmet", 3 },
                    { 5, "lorem ıpsum", true, "İnanılmaz", "Mahir", 4 },
                    { 6, "lorem ıpsum", true, "Yırtık geldi", "Eren", 5 },
                    { 7, "lorem ıpsum", true, "Bir Tanede kardeşime aldım", "İsmimi vermek istemiyorum", 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId", "Stok" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 2, 1, 10 },
                    { 3, 1, 10 },
                    { 4, 1, 10 },
                    { 5, 1, 10 },
                    { 1, 2, 10 },
                    { 2, 2, 10 },
                    { 3, 2, 10 },
                    { 4, 2, 10 },
                    { 5, 2, 10 },
                    { 1, 3, 10 },
                    { 2, 3, 10 },
                    { 3, 3, 10 },
                    { 4, 3, 10 },
                    { 5, 3, 10 },
                    { 1, 4, 10 },
                    { 2, 4, 10 },
                    { 4, 4, 10 },
                    { 5, 4, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
