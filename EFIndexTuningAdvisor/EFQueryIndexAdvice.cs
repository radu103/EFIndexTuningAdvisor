using System.Collections.Generic;

namespace EFIndexTuningAdvisor
{
    public class EFQueryIndexAdvice
    {
        private List<string> _IndexesNeeded = new List<string>();

        public string Query { get; set; }

        public string NewIndexNeeded
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _IndexesNeeded.Add(value);
            }
        }

        public List<string> IndexesNeeded => _IndexesNeeded;
    }
}