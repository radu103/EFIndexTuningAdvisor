using System;
using System.Collections.Generic;
using System.Text;

namespace EFIndexTuningAdvisor
{
    public class EFQuery
    {
        public string sql { get; set; }

        public int repeat_count { get; set; }

        public decimal avg_time_in_ms { get; set; }

        public decimal total_time_in_ms { get; set; }

        public List<EFQueryTableColumn> JoinClauses { get; set; }
        public List<EFQueryTableColumn> WhereClauses { get; set; }
        public List<EFQueryTableColumn> GroupByClauses { get; set; }
        public List<EFQueryTableColumn> OrderByClauses { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Query runned {0} times, avg time of {1} ms, with a total time {2} ms" + Environment.NewLine, repeat_count, avg_time_in_ms.ToString("0.00"), total_time_in_ms.ToString("0.00"));
            sb.AppendFormat("SQL: {0}" + Environment.NewLine, sql);

            var ret = sb.ToString();

            return ret;
        }

        public void AnalyzeQuery()
        {
            WhereClauses = AnalyzeWhereFilters.Process(sql);
            JoinClauses = AnalyzeJoins.Process(sql);
            GroupByClauses = AnalyzeGroupBys.Process(sql);
            OrderByClauses = AnalyzeOrderBys.Process(sql);
        }
    }
}