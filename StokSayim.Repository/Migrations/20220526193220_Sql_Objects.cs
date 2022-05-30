using Microsoft.EntityFrameworkCore.Migrations;
using StokSayim.Repository.Migrations.MigrationHelpers;

#nullable disable

namespace StokSayim.Repository.Migrations
{
    public partial class Sql_Objects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ViewHelper.CreateGetCountsView(migrationBuilder);
            SPHelper.CreateTestProductSP(migrationBuilder);
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            ViewHelper.DropGetCountsView(migrationBuilder);
            SPHelper.DropTestProductSP(migrationBuilder);
        }
    }
}
