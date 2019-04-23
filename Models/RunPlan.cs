using System.Collections.Generic;

namespace QualityReaction.Models
{
    public class RunPlan : AbstractDatabaseEntity
    {
        public virtual Plan Plan { get; set; }

        public virtual Status State { get; set; }

        public virtual User ModifiedBy { get; set; }

        public virtual IList<RunCase> RunCases { get; set; }
    }
}