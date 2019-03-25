using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class RunPlan
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual Status State { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<RunCase> RunCases { get; set; }
    }
}