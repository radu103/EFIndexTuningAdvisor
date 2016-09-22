using System;
using System.Collections.Generic;

namespace EFIndexTuningAdvisor
{
    public static class AnalyzeOrderBys
    {
        public static List<EFQueryTableColumn> Process(string sql)
        {
            var list = new List<EFQueryTableColumn>();

            try
            {
                var pos_s = sql.IndexOf("ORDER BY");
                if (pos_s < 0) return list;

                var analyzed_sql = sql.Substring(pos_s).Replace("ORDER BY", "").Trim();
                var oaux = analyzed_sql.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < oaux.Length; i++)
                {
                    var ww = oaux[i].Replace("ASC", "").Replace("DESC", "").Trim();

                    var ocol = new EFQueryTableColumn
                    {
                        TableName = string.Empty,
                        TableAlias = string.Empty,
                        ColumnName = ww
                    };
                    list.Add(ocol);
                }
            }
            catch (Exception err)
            {
            }

            return list;
        }
    }
}