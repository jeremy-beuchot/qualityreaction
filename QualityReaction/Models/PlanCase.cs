using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityReaction.Models
{
    public class PlanCase
    {
        public virtual Plan Plan { get; set; }
        public virtual Case Case { get; set; }
        public virtual int Index { get; set; }
        public virtual bool ReadOnly { get; set; }
    }
}