using EFIndexTuningAdvisor;
using System.Collections.Generic;

namespace EFIndexTuningAdvisorTestApp
{
    public class TestResultsForDisplay
    {
        public List<EFQueryIndexAdvice> IndexSuggestions { get; set; }

        public List<EFQuery> TopFrequentQueries { get; set; }

        public List<EFQuery> TopSlowestQueries { get; set; }

        public List<EFQuery> TopTimeConsumingQueries { get; set; }
    }
}