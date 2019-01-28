using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityReaction.Models
{
    public class RunCase
    {
        public virtual long Id { get; set; }
        public virtual Case Case { get; set; }
        public IList<RunStep> RunSteps { get; set; }
    }
}