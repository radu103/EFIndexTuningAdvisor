using System;
using System.Collections;
using System.Collections.Generic;

namespace EFIndexTuningAdvisor
{
    public static class AnalyzeWhereFilters
    {
        public static List<EFQueryTableColumn> Process(string sql)
        {
            var list = new List<EFQueryTableColumn>();

            if (sql.IndexOf("FROM INFORMATION_SCHEMA.TABLES") > 0) return list;

            try
            {
                var pos_s = sql.IndexOf("FROM");
                if(pos_s < 0) return list;

                var pos1 = sql.IndexOf("INNER JOIN");
                var pos2 = sql.IndexOf("LEFT OUTER JOIN");
                var pos3 = sql.IndexOf("RIGHT OUTER JOIN");
                var pos4 = sql.IndexOf("GROUP BY");
                var pos5 = sql.IndexOf("ORDER BY");

                var poslist = new ArrayList();
                if (pos1 > 0) poslist.Add(pos1);
                if (pos2 > 0) poslist.Add(pos2);
                if (pos3 > 0) poslist.Add(pos3);
                if (pos4 > 0) poslist.Add(pos4);
                if (pos5 > 0) poslist.Add(pos5);
                poslist.Sort();

                var pos_e = sql.Length - 1;
                if (poslist.Count > 0)
                    pos_e = Convert.ToInt32(poslist[0]);

                var analyse_str = sql.Substring(pos_s, pos_e - pos_s).Trim();

                var pos_where = analyse_str.IndexOf("WHERE");

                // extract from clause columns
                var from_str = analyse_str;
                if (pos_where > 0)
                {
                    from_str = analyse_str.Substring(0, pos_where).Replace("FROM", "").Trim();
                }
                var faux = from_str.Split(new string[] { "AS" }, StringSplitOptions.RemoveEmptyEntries);
                if (faux.Length != 2) return list;

                var fcol = new EFQueryTableColumn
                {
                    TableName = faux[0].Trim(),
                    TableAlias = faux[1].Trim()
                };

                // extract Where clause columns
                if (pos_where > 0)
                {
                    var where_str = analyse_str.Substring(pos_where).Replace("WHERE", "").Replace("(", "").Replace(")", "").Trim();
                    var waux = where_str.Split(new string[] { "AND", "OR" }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < waux.Length; i++)
                    {
                        var ww = waux[i].Split(new string[] { "=", ">=", "<=", ">", "<", "LIKE" }, StringSplitOptions.RemoveEmptyEntries);
                        var left = ww[0].Trim();
                        if (ww.Length == 1)
                        {
                        }

                        var right = ww[1].Trim();

                        if (left.IndexOf(fcol.TableAlias) >= 0)
                        {
                            var wcol = new EFQueryTableColumn
                            {
                                TableName = fcol.TableName,
                                TableAlias = fcol.TableAlias,
                                ColumnName = left.Replace(fcol.TableAlias + ".", "")
                            };
                            list.Add(wcol);
                        }

                        if (right.IndexOf(fcol.TableAlias) >= 0)
                        {
                            var wcol = new EFQueryTableColumn
                            {
                                TableName = fcol.TableName,
                                TableAlias = fcol.TableAlias,
                                ColumnName = right.Replace(fcol.TableAlias + ".", "")
                            };
                            list.Add(wcol);
                        }
                    }
                }
            }
            catch (Exception err)
            {
            }

            return list;
        }
    }
}