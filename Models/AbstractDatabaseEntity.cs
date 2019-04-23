using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityReaction.Models
{
    public abstract class AbstractDatabaseEntity
    {
        public Guid Id { get; set; }
    }
}
