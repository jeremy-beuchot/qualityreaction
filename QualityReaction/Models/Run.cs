using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class Run
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual Version Version { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual ICollection<RunPlan> RunPlans { get; set; }
        public virtual string Description { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}