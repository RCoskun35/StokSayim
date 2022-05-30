using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Repository.Migrations.MigrationHelpers
{
    public static class ViewHelper
    {
        public static void CreateGetCountsView(MigrationBuilder builder)
        {
            builder.Sql(@"create view GetCounts as
           SELECT dbo.Stocks.Code StokKodu, dbo.Counts.State SayimDurumu, dbo.Counts.Quantity SayimMiktari, dbo.Counts.ReadDate OkumaTarihi, dbo.Counts.SendDate GonderimTarihi, dbo.Employees.SurName OkuyanSoyadi, dbo.Employees.Name OkuyanAdi, dbo.Employees.IdentificationNumber OkuyanKimlikNo, dbo.Locations.[Read] LokasyonDurumu,dbo.Locations.Name AS LokasyonAdi, dbo.Stocks.Explanation UrunAciklamasi, dbo.Stocks.Unit UrunBirimi, dbo.Stocks.Quantity AS StokMiktari, dbo.Stocks.ExpirationDate SonKullanimTarihi, dbo.Stocks.Name AS UrunAdi, dbo.Terminals.IPAdress TerminalIpAdresi, dbo.Terminals.Name AS TerminalAdi FROM dbo.Counts INNER JOIN dbo.Employees ON dbo.Counts.EmployeeId = dbo.Employees.Id INNER JOIN dbo.Locations ON dbo.Counts.LocationId=dbo.Locations.Id INNER JOIN dbo.Stocks ON dbo.Counts.Code = dbo.Stocks.Code INNER JOIN dbo.Terminals ON dbo.Counts.TerminalId = dbo.Terminals.Id");
        }
        public static void DropGetCountsView(MigrationBuilder builder)
        {
            builder.Sql("drop view GetCounts");
        }


        public static void CreateViewCounts(MigrationBuilder builder)
        {
            builder.Sql(@"create view ViewCounts as
            SELECT
		   dbo.Terminals.Id TerminalID,
		   dbo.Stocks.Code StokKodu, dbo.Counts.State SayimDurumu, dbo.Counts.Quantity SayimMiktari, dbo.Counts.ReadDate OkumaTarihi, dbo.Counts.SendDate GonderimTarihi, dbo.Employees.SurName OkuyanSoyadi, dbo.Employees.Name OkuyanAdi, dbo.Employees.IdentificationNumber OkuyanKimlikNo, dbo.Locations.[Read] LokasyonDurumu,dbo.Locations.Name AS LokasyonAdi, dbo.Stocks.Explanation UrunAciklamasi, dbo.Stocks.Unit UrunBirimi, dbo.Stocks.Quantity AS StokMiktari, dbo.Stocks.ExpirationDate SonKullanimTarihi, dbo.Stocks.Name AS UrunAdi, dbo.Terminals.IPAdress TerminalIpAdresi, dbo.Terminals.Name AS TerminalAdi FROM dbo.Counts left JOIN dbo.Employees ON dbo.Counts.EmployeeId = dbo.Employees.Id left JOIN dbo.Locations ON dbo.Counts.LocationId=dbo.Locations.Id left JOIN dbo.Stocks ON dbo.Counts.Code = dbo.Stocks.Code left JOIN dbo.Terminals ON dbo.Counts.TerminalId = dbo.Terminals.Id");
        }
        public static void DropViewCounts(MigrationBuilder builder)
        {
            builder.Sql("drop view ViewCounts");
        }

        public static void CreateViewStocks(MigrationBuilder builder)
        {
            builder.Sql(@"create view ViewStocks as
           SELECT l.name  LokasyonAdi, s.Id StokId,s.Code StokKodu,s.Explanation StokAciklamasi,
  s.Quantity StokAdedi,	s.Unit StokBirimi,	s.LocationId StokLokasyonId,s.ExpirationDate StokSonKullanmaTarihi,	s.Name	StokUrunAdi,s.State StokDurumu from Stocks s left join Locations l on s.LocationId = l.Id");
        }
        public static void DropViewStocks(MigrationBuilder builder)
        {
            builder.Sql("drop view ViewStocks");
        }



    }
}
