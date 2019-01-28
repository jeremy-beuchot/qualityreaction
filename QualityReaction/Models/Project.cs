using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityReaction.Models
{
    public class Project
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Picture { get; set; }
        public virtual bool Discontinued { get; set; }
    }
}