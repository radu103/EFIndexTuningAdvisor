using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;

namespace EFIndexTuningAdvisor
{
    public static class EFIndexAdvisorExtension
    {
        public static void StartCaptureSQLSelects(this DbContext context)
        {
            DbInterception.Add(new EFCommandInterceptorForTuning());
        }

        public static void StopCaptureSQLSelects(this DbContext context)
        {
            DbInterception.Remove(new EFCommandInterceptorForTuning());
            RecommendIndexes();
        }

        public static void FlushCapturedSQLSelects(this DbContext context)
        {
            EFSelectQueryCache.FlushLog();
        }

        private static void RecommendIndexes()
        {
            var key_queries = EFSelectQueryCache.QueryLog.OrderByDescending(k => k.repeat_count);

            foreach (var query in key_queries)
            {
                var adv = new EFQueryIndexAdvice { Query = query.ToString() };
                QueryIndexAdvices.NewIndexAdvice(adv);
            }
        }

        public static List<EFQueryIndexAdvice> GetIndexAdviceList(this DbContext context)
        {
            return QueryIndexAdvices.List;
        }

        public static List<EFQuery> GetTopFrequentQueries(this DbContext context, int how_many = 20)
        {
            return EFSelectQueryCache.QueryLog.OrderByDescending(q => q.repeat_count).Take(how_many).ToList();
        }

        public static List<EFQuery> GetTopSlowestQueries(this DbContext context, int how_many = 20)
        {
            return EFSelectQueryCache.QueryLog.OrderByDescending(q => q.time_in_ms).Take(how_many).ToList();
        }

        public static List<EFQuery> GetTopTimeConsumingQueries(this DbContext context, int how_many = 20)
        {
            return EFSelectQueryCache.QueryLog.OrderByDescending(q => q.total_time_in_ms).Take(how_many).ToList();
        }
    }
}