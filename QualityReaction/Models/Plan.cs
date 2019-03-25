using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class Plan
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual Version Version { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual Project Project { get; set; }

        public virtual ICollection<PlanCase> PlanCases { get; set; }
    }
}