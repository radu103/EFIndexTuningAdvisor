using System.Data.Common;

namespace EFIndexTuningAdvisor
{
    public class EFQuery
    {
        public string sql { get; set; }

        public DbParameterCollection param { get; set; }

        public int repeat_count { get; set; }

        public decimal time_in_ms { get; set; }

        public decimal total_time_in_ms { get; set; }
    }
}