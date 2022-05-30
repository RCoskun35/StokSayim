using Microsoft.EntityFrameworkCore.Migrations;
using StokSayim.Repository.Migrations.MigrationHelpers;

#nullable disable

namespace StokSayim.Repository.Migrations
{
    public partial class AddView_StocksAndCounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ViewHelper.CreateViewCounts(migrationBuilder);
            ViewHelper.CreateViewStocks(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            ViewHelper.DropViewStocks(migrationBuilder);
            ViewHelper.DropViewCounts(migrationBuilder);

        }
    }
}
