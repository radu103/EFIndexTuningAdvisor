using System;
using System.Collections.Generic;

namespace EFIndexTuningAdvisor
{
    public static class QueryIndexAdvices
    {
        private static List<EFQueryIndexAdvice> _List = new List<EFQueryIndexAdvice>();

        public static List<EFQueryIndexAdvice> List
        {
            get
            {
                return _List;
            }
        }

        public static void NewIndexAdvice(EFQueryIndexAdvice advice)
        {
            _List.Add(advice);
        }
    }
}