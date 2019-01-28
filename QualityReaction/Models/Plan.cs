using System.Collections.Generic;

namespace QualityReaction.Models
{
    public class Plan
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<PlanCase> PlanCases { get; set; }
        public virtual Version Version { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual Project Project { get; set; }
    }
}