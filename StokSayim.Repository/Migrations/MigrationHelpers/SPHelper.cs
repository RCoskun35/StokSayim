using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Repository.Migrations.MigrationHelpers
{
    public class SPHelper
    {
        public static void CreateTestProductSP(MigrationBuilder builder)
        {
            builder.Sql(@"CREATE PROCEDURE ProcTest AS BEGIN select * from Counts END");
        }
        public static void DropTestProductSP(MigrationBuilder builder)
        {
            builder.Sql("drop procedure ProcTest");
        }
    }
}
