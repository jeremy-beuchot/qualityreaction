using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityReaction.Models
{
    public class Case
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<CaseStep> CaseSteps { get; set; } = new List<CaseStep>();
        public virtual string Requirements { get; set; }
        public virtual Version Version { get; set; }
        public virtual IList<string> Tickets { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual string Title { get; set; }
    }
}