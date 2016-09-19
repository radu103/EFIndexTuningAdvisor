using System.Data.Common;

namespace EFIndexTuningAdvisor
{
    public static class DbParamCollectionExtensions
    {
        public static string GetParamHash(this DbParameterCollection param)
        {
            string ret_h = string.Empty;

            foreach (DbParameter p in param)
            {
                ret_h += string.Format("{0}_", p.ParameterName);
            }

            return ret_h;
        }
    }
}