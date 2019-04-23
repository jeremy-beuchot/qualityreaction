using System.Collections.Generic;

namespace QualityReaction.Models
{
    public class RunCase : AbstractDatabaseEntity
    {

        public virtual Case Case { get; set; }

        public IList<RunStep> RunSteps { get; set; }
    }
}