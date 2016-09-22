using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace EFIndexTuningAdvisor
{
    public static class EFSelectQueryCache
    {
        private static List<EFQuery> _QueryLog = new List<EFQuery>();

        public static List<EFQuery> QueryLog
        {
            get
            {
                return _QueryLog;
            }
        }

        public static void FlushLog()
        {
            _QueryLog.Clear();
            System.GC.Collect();
        }

        public static void AddQueryToLog(string sql, decimal time_ms)
        {
            if (string.IsNullOrEmpty(sql)) return;

            var sqlt = sql.Trim();

            EFQuery old_val = _QueryLog.Find(e => string.Compare(sqlt, e.sql, System.StringComparison.Ordinal) == 0);

            if (old_val != null)
            {
                old_val.avg_time_in_ms = (old_val.avg_time_in_ms * old_val.repeat_count + time_ms) / (old_val.repeat_count + 1);
                old_val.repeat_count += 1;
                old_val.total_time_in_ms += time_ms;
            }
            else
            {
                EFQuery new_val = new EFQuery();
                new_val.sql = sqlt;
                new_val.repeat_count = 1;
                new_val.avg_time_in_ms = time_ms;
                new_val.total_time_in_ms = time_ms;

                _QueryLog.Add(new_val);
            }
        }
    }
}