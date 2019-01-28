using System.Collections.Generic;

namespace QualityReaction.Models
{
    public class RunCase
    {
        public virtual long Id { get; set; }
        public virtual Case Case { get; set; }
        public IList<RunStep> RunSteps { get; set; }
    }
}