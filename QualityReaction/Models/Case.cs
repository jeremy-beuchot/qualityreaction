using System.Collections.Generic;

namespace QualityReaction.Models
{
    public class Case
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Requirements { get; set; }
        public virtual Version Version { get; set; }
        public virtual ICollection<string> Tickets { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual string Title { get; set; }

        public virtual ICollection<CaseStep> CaseSteps { get; set; }
        public virtual ICollection<PlanCase> PlanCases { get; set; }
    }
}