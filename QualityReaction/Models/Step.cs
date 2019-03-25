using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class Step
    {        
        [Key]
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string ExpectendResult { get; set; }

        public virtual ICollection<CaseStep> CaseSteps { get; set; }
    }
}