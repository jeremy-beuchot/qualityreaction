using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityReaction.Models
{
    public class Step
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string ExpectendResult { get; set; }
    }
}