using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularDemo.Migrations {
    public partial class InitialCreate : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable (
                name: "Accounts",
                columns : table => new {
                    ID = table.Column<int> (nullable: false)
                        .Annotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        UserName = table.Column<string> (nullable: true),
                        Password = table.Column<string> (nullable: true)
                },
                constraints : table => {
                    table.PrimaryKey ("PK_Accounts", x => x.ID);
                });

            migrationBuilder.CreateTable (
                name: "Categories",
                columns : table => new {
                    CategoryID = table.Column<int> (nullable: false)
                        .Annotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        CategoryName = table.Column<string> (nullable: true),
                        Desctiption = table.Column<string> (nullable: true)
                },
                constraints : table => {
                    table.PrimaryKey ("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable (
                name: "Products",
                columns : table => new {
                    ProductID = table.Column<int> (nullable: false)
                        .Annotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        ProductName = table.Column<string> (nullable: true),
                        Description = table.Column<string> (nullable: true),
                        ImagePath = table.Column<string> (nullable: true),
                        UnitPrice = table.Column<double> (nullable: true),
                        CategoryID = table.Column<int> (nullable: true)
                },
                constraints : table => {
                    table.PrimaryKey ("PK_Products", x => x.ProductID);
                    table.ForeignKey (
                        name: "FK_Products_Categories_CategoryID",
                        column : x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete : ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex (
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down (MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable (
                name: "Accounts");

            migrationBuilder.DropTable (
                name: "Products");

            migrationBuilder.DropTable (
                name: "Categories");
        }
    }
}