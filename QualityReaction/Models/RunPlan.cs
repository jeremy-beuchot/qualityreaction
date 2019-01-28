using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityReaction.Models
{
    public class RunPlan
    {
        public virtual long Id { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual Status State { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual IList<RunCase> RunCases { get; set; }
    }
}