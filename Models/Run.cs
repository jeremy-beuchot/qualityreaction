using System.Collections.Generic;

namespace QualityReaction.Models
{
    public class Run : AbstractDatabaseEntity
    {

        public virtual Version Version { get; set; }

        public virtual IList<Plan> Plans { get; set; }

        public virtual IList<RunPlan> RunPlans { get; set; }

        public virtual string Description { get; set; }

        public virtual User CreatedBy { get; set; }
    }
}