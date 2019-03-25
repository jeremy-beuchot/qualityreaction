using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class RunCase
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual Case Case { get; set; }
        public ICollection<RunStep> RunSteps { get; set; }
    }
}