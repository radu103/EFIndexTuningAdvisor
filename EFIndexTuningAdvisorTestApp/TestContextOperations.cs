using System.Linq;
using WideWorldImportersDomain;

namespace EFIndexTuningAdvisorTestApp
{
    public static class TestContextOperations
    {
        public static void doQueries(WideWorldImporters ctx)
        {
            var repeat = 0;

            do
            {
                var c1 = ctx.Countries.Where(c => c.IsoAlpha3Code == "USA").OrderBy(c => c.CountryName).ToList();
                c1 = ctx.Countries.Where(c => c.IsoAlpha3Code.StartsWith("U")).OrderBy(c => c.CountryName).ToList();

                var c2 = ctx.Cities.Where(c => c.LatestRecordedPopulation >= 300000).ToList();
                c2 = ctx.Cities.Where(c => c.LatestRecordedPopulation >= 300000).ToList();

                var a1 = ctx.Customers.Include("City").Include("Person").Include("CustomerCategory").Where(c => c.CreditLimit > 0).ToList();
                a1 = ctx.Customers.Include("CustomerCategory").Where(c => c.CreditLimit > 0).OrderByDescending(c => c.CreditLimit).ToList();
                a1 = ctx.Customers.Include("City").Include("CustomerCategory").Where(c => c.City.LatestRecordedPopulation > 100000).OrderByDescending(c => c.CreditLimit).ToList();

                repeat += 1;
            } while (repeat < 3);

            // feels free to add any EF queries here
            //
            //
        }
    }
}